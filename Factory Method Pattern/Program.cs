using System;

namespace Factory_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            String op = "N";
            AnimalFactory factory = new AnimalFactory();
            while (op != "Y")
            {
                var animal = factory.CreateAnimal();
                Console.Clear();
                Console.WriteLine("You are an ............");
                animal.Design();   
                Console.WriteLine("Want exit? (Y/N)");
                op = Console.ReadLine();
            }
        }
    }
}
