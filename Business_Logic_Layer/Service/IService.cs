using IPluginLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.ServiceDir
{
    public interface IService
    {
        int Exequte();
        PluginInfo GetExtensionInfo();
    }
}
