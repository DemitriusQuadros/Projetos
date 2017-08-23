using System;

namespace Factory_Method_Pattern
{
    //this class is responsable for controle the creation of animals in the program
    public class AnimalFactory : IAnimalFactory
    {
        protected String next;

        public Animal CreateAnimal()
        {
            if ((next == "") || (next == "lion"))
            {
                next = "bird";
                return new Lion();
            }
            else if (next == "bird")
            {
                next = "dog";
                return new Bird();
            }
            else
            {
                next = "lion";
                return new Dog();
            }
        }
    }
}
