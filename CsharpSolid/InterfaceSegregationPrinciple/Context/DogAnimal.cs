using System;
namespace CsharpSolid.InterfaceSegregationPrinciple.Context {
    interface DogAnimal : Animal {
        public void bark();

        public void run();
    }
}