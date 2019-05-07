﻿using IPluginLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPluginLibrary.Service
{
    interface IPluginService
    {
        PluginInfo[] GetExtensionInfo();
        void InitialContexts();
        int ExequteExtension();
    }
}