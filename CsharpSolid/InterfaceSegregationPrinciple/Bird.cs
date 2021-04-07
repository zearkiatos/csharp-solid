using System;
namespace CsharpSolid.InterfaceSegregationPrinciple {
    interface Bird : Animal {
        public void run();

        public void fly();
    }
}