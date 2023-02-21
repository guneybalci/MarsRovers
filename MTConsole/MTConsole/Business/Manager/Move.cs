using MTConsole.Business.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTConsole.Business.Manager
{
    public class Move : IMove
    {
        private ILocation _location;
        private IRover _spinLeft;
        private IRover _spinRight;
        private IRover _stepForward;
        public Move(ILocation location)
        {
            _location = location;
            _spinLeft = new SpinLeft(_location);
            _spinRight = new SpinRight(_location);
            _stepForward = new StepForward(_location);
        }
        public void ToMove(string roverCommand)// LMLMLMLMMM
        {
            char[] instructions = roverCommand.ToCharArray();
            // lloop through array, for each letter call spinleft spingright or spinforward

            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        _spinLeft.Direction();
                        break;
                    case 'R':
                        _spinRight.Direction();
                        break;
                    case 'M':
                        _stepForward.Direction();
                        break;
                    default:
                        throw new ArgumentException("Invalid Move");
                }
            }
        }
    }
}
