using IPluginLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPluginLibrary.Service
{
    public interface IPluginService
    {
        PluginInfo[] GetExtensionInfo();
        void InitialContexts();
        IPlugin FindExtension(string ExtensionName, string ActionName);
    }
}
