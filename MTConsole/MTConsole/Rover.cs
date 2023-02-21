using System;
using System.Collections.Generic;
using System.Text;

namespace MTConsole
{
    public class Rover
    {
        public int x; // x coordinate of the current rover position
        public int y; // y coordinate of the current rover position
        public string direction; // cardinal direction of the current rover position

        // 2. inputtan aldıklarımız 1-2-N
        public Rover(string location)
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];
        }

        public void SpinLeft()
        {

            switch (direction)
            {
                // saat yönünün tersi oldugu icin y+1 demek sol a doğru bakmasını soyler
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }

        }

        public void SpinRight()
        {

            switch (direction)
            {
                // saat yönünün tersi oldugu icin y+1 demek sol a doğru bakmasını soyler
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }

        }

        public void StepForward()
        {
            switch (direction)
            {
                // saat yönünün tersi oldugu icin y+1 demek sol a doğru bakmasını soyler
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= -1;
                    break;
                case "W":
                    x-= -1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }


        public void Move(string roverCommand) // LMLMLMLMMMM
        {
            char[] instructions = roverCommand.ToCharArray();
            // lloop through array, for each letter call spinleft spingright or spinforward

            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
