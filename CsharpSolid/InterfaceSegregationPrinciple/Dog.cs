using System;
namespace CsharpSolid.InterfaceSegregationPrinciple {
    interface Dog : Animal {
        public void bark();

        public void fly();
    }
}