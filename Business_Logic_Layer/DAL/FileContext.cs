
using IPluginLibrary.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business_Logic_Layer
{
    public class FileContext : IFileContext
    {
        private string Dir { get; set; }
        public FileContext(string WorkDir)
        {
            Dir = WorkDir;
        }

        public FileContext()
        {
            Dir = @"C:\Users\user\Desktop\Default";
        }

        public void WriteAllText(string FileName, string data)
        {
            File.WriteAllText(Dir + "\\" + FileName, data);
        }

        public string ReadAllText(string FileName)
        {
            return File.ReadAllText(Dir + "\\" + FileName);
        }
    }
}
