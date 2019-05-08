using System;
using System.Collections.Generic;
using System.Text;

namespace PluginDataContext
{
    public interface IFileContext
    {
        void WriteAllText(string FileName, string data);
        string ReadAllText(string FileName);
    }
}
