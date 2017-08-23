using System;

// this interface define how create an animal

namespace Factory_Method_Pattern
{
    public interface IAnimalFactory
    {
        Animal CreateAnimal();
    }
}
