using MTConsole.Business.Services;
using MTConsole.Enums;
using MTConsole.Extensions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MTConsole.Business.Manager
{
    public class StepForward : IRover
    {
        private ILocation _location;
        public StepForward(ILocation location)
        {
            _location = location;
        }

        public string Direction()
        {
            var initialX = _location.X;
            var initialY = _location.Y;

            List<int> coordinateList = new List<int>();

            switch (_location.Direction)
            {
                case var value when value == Orientation.North.GetEnumDescription():
                    _location.Y += 1;
                    break;
                case var value when value == Orientation.East.GetEnumDescription():
                    _location.X += 1;
                    break;
                case var value when value == Orientation.South.GetEnumDescription():
                    _location.Y -= 1;
                    break;
                case var value when value == Orientation.West.GetEnumDescription():
                    _location.X -= 1;
                    break;
                default:
                    throw new ArgumentException("Invalid Rover Coordinate");
            }

            coordinateList.Add(_location.X);
            coordinateList.Add(_location.Y);
            int result = CheckCoorditaneValue(initialX, initialY, coordinateList);
            return result.ToString();
        }


        private int CheckCoorditaneValue(int defaultX, int defaultY, List<int> coordinateList)
        {
            int value = 0;
            for (int i = 0; i < coordinateList.Count; i++)
            {
                if (defaultX != coordinateList[0])
                {
                    value = coordinateList[0];
                }
                else if (defaultY != coordinateList[1])
                {
                    value = coordinateList[1];
                }
            }

            return value;
        }
    }
}
