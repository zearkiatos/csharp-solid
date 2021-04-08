using CsharpSolid.InterfaceSegregationPrinciple.Context;
using System;
namespace CsharpSolid.InterfaceSegregationPrinciple.Models {
    public class Bird : BirdAnimal {
        public void run() {
            Console.WriteLine("🦜 Bird is running");
        }

        public void fly() {
            Console.WriteLine("🦜 Bird is flying");
        }
    }
}