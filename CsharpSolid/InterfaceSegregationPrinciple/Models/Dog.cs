using CsharpSolid.InterfaceSegregationPrinciple.Context;
using System;
namespace CsharpSolid.InterfaceSegregationPrinciple.Models
{
    public class Dog : DogAnimal
    {
        public void run()
        {
            Console.WriteLine("🦮 Dog is running");
        }

        public void bark()
        {
            Console.WriteLine("🦮 Dog is barking");
        }
    }
}