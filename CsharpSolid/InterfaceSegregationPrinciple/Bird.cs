using System;
namespace CsharpSolid.InterfaceSegregationPrinciple {
    public class Bird : Animal {
        public void executeAction(string action) {
            Console.WriteLine(action);
        }
    }
}