using Xunit;
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
            Console.Clear();
            var currentConsoleOut = Console.Out;
            Bird bird = new Bird();
            string text = "🦜 Bird is flying\n";

            using (var consoleOutput = new ConsoleMock())
            {
                bird.fly();
                Assert.Equal(text, consoleOutput.GetOuput());
            }

            Assert.Equal(currentConsoleOut, Console.Out);
        }
    }
}