using Xunit;
using Moq;
using System;
using CsharpSolid.InterfaceSegregationPrinciple.Models;
using CsharpSolid.Tests.InterfaceSegregationPrinciple.Helpers;


namespace CsharpSolid.Tests.InterfaceSegregationPrinciple
{
    public class BirdUnitTest
    {
        [Fact]
        public void Should_send_and_return_and_execute_action()
        {
            Mock<Bird> birdMock = new Mock<Bird>();
            birdMock.CallBase = true;
            ConsoleMock consoleMock = new ConsoleMock();
            // birdMock.Setup(x => x.fly()).Raises()
            string expectedConsoleWriteLine = "🦜 Bird is flying";
            Bird birdTest = new Bird();
            birdTest.fly();

            Assert.Equal(expectedConsoleWriteLine, Environment.NewLine);

        }
    }
}