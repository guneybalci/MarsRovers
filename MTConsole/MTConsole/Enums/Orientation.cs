using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MTConsole.Enums
{
    public enum Orientation
    {
        [Description("N")]
        North,
        [Description("S")]
        South,
        [Description("E")]
        East,
        [Description("W")]
        West
    }
}
