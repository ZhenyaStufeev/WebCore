using IPluginLibrary.Context;
using IPluginLibrary.Entity;
using System;

namespace IPluginLibrary
{
    public interface IPlugin
    {
        PluginInfo GetInfo();
        int Exequte();
        void InitialContext(IFileContext fileService);
    }
}
