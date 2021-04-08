using System;
namespace CsharpSolid.InterfaceSegregationPrinciple.Context {
    interface BirdAnimal : Animal {
        public void run();

        public void fly();
    }
}