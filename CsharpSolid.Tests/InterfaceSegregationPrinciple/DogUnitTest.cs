using Xunit;
using System;
using CsharpSolid.InterfaceSegregationPrinciple.Models;
using CsharpSolid.Tests.InterfaceSegregationPrinciple.Helpers;
namespace CsharpSolid.Tests.InterfaceSegregationPrinciple
{
    public class DogUnitTest
    {
        [Fact]
        public void Should_send_and_return_and_execute_action()
        {
            Console.Clear();
            var currentConsoleOut = Console.Out;
            Dog dog = new Dog();
            string text = "🦮 Dog is running\n";

            using (var consoleOutput = new ConsoleMock())
            {
                consoleOutput.CleanOutput();
                dog.run();
                Assert.Equal(text, consoleOutput.GetOuput());
            }

            Assert.Equal(currentConsoleOut, Console.Out);

        }
    }
}