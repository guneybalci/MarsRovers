using MTConsole.Business.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTConsole.Business.Manager
{
    public class Location : ILocation
    {
        private string _location;
        private int _x;
        private int _y;
        private string _direction;
        public Location(string location)
        {
            this._location = location;
            this.X = Convert.ToInt32(_location.Split(" ")[0]);
            this.Y = Convert.ToInt32(_location.Split(" ")[1]);
            this.Direction = _location.Split(" ")[2];
        }
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public string Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;

            }
        }
    }
}
