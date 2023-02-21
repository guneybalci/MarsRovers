using System;
using System.Collections.Generic;
using System.Text;

namespace MTConsole.Business.Services
{
    public interface ILocation
    {
        int X { get; set; }

        int Y { get; set; }

        string Direction { get; set; }
    }
}
