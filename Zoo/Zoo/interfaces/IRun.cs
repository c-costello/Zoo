using System;
using System.Collections.Generic;
using System.Text;
using Zoo.interfaces;

namespace Zoo.interfaces
{
    interface IRun
    {
        int TopSpeed { get; set; }
        string Run();
    }
}
