using System;
using System.Collections.Generic;
using System.Text;
using Business_Logic_Layer.ServiceDir;
using IPluginLibrary.Context;

namespace Business_Logic_Layer.ServiceCreator
{
    public class ServiceCreator : IServiceCreator
    {
        public IService Create()
        {
            return new Service(new FileContext() as IFileContext);
        }
    }
}
