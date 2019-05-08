using Business_Logic_Layer.ServiceDir;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.ServiceCreator
{
    public interface IServiceCreator
    {
        IService Create();
    }
}
