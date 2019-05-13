
using IPluginLibrary;
using IPluginLibrary.Service;
using IPluginLibrary.Context;
using IPluginLibrary.Entity;

namespace Business_Logic_Layer.ServiceDir
{
    public class Service: IService
    {
        private IPluginService ExtensionsContext;


        public Service(IFileContext fileContext)
        {
            ExtensionsContext = new PluginService(fileContext);
            ExtensionsContext.InitialContexts();
        }

        public int Exequte()
        {
            return 0;
        }

        public PluginInfo GetExtensionInfo()
        {
            return null;
        }
    }
}
