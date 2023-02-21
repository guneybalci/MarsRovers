using MTConsole;
using MTConsole.Business.Manager;
using MTConsole.Business.Services;
using System;
using Xunit;

namespace MarsRoverTests
{
    public class RoverShould
    {
        ILocation location = new Location("1 2 N");

        [Fact]
        public void SpinLeft()
        {
            SpinLeft spinLeft = new SpinLeft(location);
            string resultSpinLeft = spinLeft.Direction();
            Assert.Equal("W", resultSpinLeft);
        }

        [Fact]
        public void SpinRight()
        {
            SpinRight spinRight = new SpinRight(location);
            string resultSpinRight = spinRight.Direction();
            Assert.Equal("E", resultSpinRight);
        }

        [Fact]
        public void StepForward()
        {
            StepForward stepForward = new StepForward(location);
            string resultStepForward = stepForward.Direction();
            Assert.Equal(3, Convert.ToInt32(resultStepForward));
        }

        [Fact]
        public void Move()
        {
            Move move = new Move(location);
            move.ToMove("LMLMLMLMM");
            Assert.Equal("1 3 N", location.X + " " + location.Y + " " + location.Direction);
        }
    }
}
