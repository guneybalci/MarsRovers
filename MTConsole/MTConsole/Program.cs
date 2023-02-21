using MTConsole.Business.Manager;
using MTConsole.Business.Services;
using MTConsole.Enums;
using MTConsole.Extensions;
using System;
using System.Collections.Generic;

namespace MTConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1:
            //ILocation location = new Location("1 2 N");
            ILocation location = new Location("3 3 E");

            Move move = new Move(location);
            //move.ToMove("LMLMLMLMM");
            move.ToMove("MMRMMRMRRM");

            //Console.WriteLine("1 3 N", location.X + " " + location.Y + " " + location.Direction);
            Console.WriteLine(location.X + " " + location.Y + " " + location.Direction);

            Console.ReadLine();
        }
    }
}
