using System;
namespace CsharpSolid.InterfaceSegregationPrinciple {
    public class Dog : Animal {
        public void executeAction(string action) {
            Console.WriteLine(action);
        }
    }
}