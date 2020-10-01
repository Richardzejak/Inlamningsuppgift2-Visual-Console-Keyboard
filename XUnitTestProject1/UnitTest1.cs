using Inlamningsuppgift_2;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            double expected = 5;

            // Act
            double actual = Program.Add(3, 2);

            // Assert
            Assert.Equal(expected, actual);


        }
        [Fact]
        public void Test2()
        {
            var sim = new WindowsInput.InputSimulator();
            sim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_Q);


        }
    }
}
