using Xunit;
using CsharpSolid.InterfaceSegregationPrinciple.Models;
using Moq;
using System;
using System.IO;


namespace CsharpSolid.Tests.InterfaceSegregationPrinciple
{
    public class BirdUnitTest
    {
        [Fact]
        public void Should_send_and_return_and_execute_action()
        {
            Mock.
            string expectedConsoleWriteLine = "🦜 Bird is flying";
            Bird birdTest = new Bird();

            birdTest.fly();

            Assert.Equal(expectedConsoleWriteLine, Environment.NewLine);
            
        }
    }
}