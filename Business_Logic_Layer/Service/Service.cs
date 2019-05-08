
using Business_Logic_Layer.Entity;
using IPluginLibrary;
using IPluginLibrary.Service;
using IPluginLibrary.Context;

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

        public ExtensionInfo GetExtensionInfo()
        {
            return null;
        }
    }
}
