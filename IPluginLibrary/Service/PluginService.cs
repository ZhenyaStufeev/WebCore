using IPluginLibrary.Context;
using IPluginLibrary.Entity;
using IPluginLibrary.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace IPluginLibrary
{
    public class PluginService: IPluginService
    {
        private List<PluginAssemblyLoadContext> contexts = new List<PluginAssemblyLoadContext>();
        private string[] plugins { get; set; }
        private string BaseDir { get; set; }
        IFileContext context { get; set; }
        public PluginService(IFileContext fileContext)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            string baseDir = Path.GetDirectoryName(path);

            LoadOnDir(baseDir + @"/plugins");
            context = fileContext;
        }
        
        public PluginService(string baseDir, IFileContext fileContext)
        {
            LoadOnDir(baseDir);
            context = fileContext;
        }
        public PluginService(string[] dir_plugins, IFileContext fileContext)
        {
            LoadOnDir(dir_plugins);
            context = fileContext;
        }
        private void LoadOnDir(string plugins_path)
        {
            if (!Directory.Exists(plugins_path))
                Directory.CreateDirectory(plugins_path);

            plugins = new string[1];
            plugins[0] = plugins_path;
        }
        private void LoadOnDir(string[] plugins_path)
        {
            foreach (string path in plugins_path)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }

            plugins = plugins_path;

        }

        /// <summary>
        /// Initializes all extensions contexts
        /// </summary>
        /// <returns>void</returns>
        public void InitialContexts()
        {
            Type pluginType = typeof(IPlugin);

            foreach (string pluginPath in plugins)
            {
                PluginAssemblyLoadContext context = new PluginAssemblyLoadContext(pluginPath, pluginType);
                context.Initialize();
                contexts.Add(context);
            }
        }

        public PluginInfo[] GetExtensionInfo()
        {
            List<PluginInfo> extension_info = new List<PluginInfo>();

            foreach (var context in contexts)
                foreach (var plugin in context.GetImplementations<IPlugin>())
                    extension_info.Add(plugin.GetInfo());

            return extension_info.ToArray();
        }

        public IPlugin FindExtension(string ExtensionName, string ActionName)
        {
            foreach (var context in contexts)
                foreach (var plugin in context.GetImplementations<IPlugin>())
                    if (plugin.Verify(ExtensionName, ActionName))
                        return plugin;
            return null;
        }
    }
}
