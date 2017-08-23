using System;

/*
Esta é uma classe concreta para o uso do contexto
 */
namespace Decorator_Pattern
{
    public class Cafe : Bebida
    {
        public override Double preco()
        {
            return 3;
        }
    }
}
