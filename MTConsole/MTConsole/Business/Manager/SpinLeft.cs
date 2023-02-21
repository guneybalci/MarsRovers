using MTConsole.Business.Services;
using MTConsole.Enums;
using MTConsole.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTConsole.Business.Manager
{
    public class SpinLeft : IRover
    {
        private ILocation _location;
        public SpinLeft(ILocation location)
        {
            _location = location;
        }

        public string Direction()
        {

            switch (_location.Direction)
            {
                case var value when value == Orientation.North.GetEnumDescription():
                    _location.Direction = Orientation.West.GetEnumDescription();
                    break;
                case var value when value == Orientation.East.GetEnumDescription():
                    _location.Direction = Orientation.North.GetEnumDescription();
                    break;
                case var value when value == Orientation.South.GetEnumDescription():
                    _location.Direction = Orientation.East.GetEnumDescription();
                    break;
                case var value when value == Orientation.West.GetEnumDescription():
                    _location.Direction = Orientation.South.GetEnumDescription();
                    break;
                default:
                    throw new ArgumentException("Invalid Rover Left Direction");
            }

            return _location.Direction;
        }
    }
}
