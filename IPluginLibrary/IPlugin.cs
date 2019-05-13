using IPluginLibrary.Context;
using IPluginLibrary.Entity;
using System;

namespace IPluginLibrary
{
    public interface IPlugin
    {
        void Exequte();
        void SetDataTransport(IFileContext fileService);
        bool Verify(string ExtensionName, string ActionName);
        PluginInfo GetInfo();
    }
}
