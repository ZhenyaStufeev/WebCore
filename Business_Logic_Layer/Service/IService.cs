using IPluginLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Business_Logic_Layer.Entity;

namespace Business_Logic_Layer.ServiceDir
{
    public interface IService
    {
        int Exequte();
        ExtensionInfo GetExtensionInfo();
    }
}
