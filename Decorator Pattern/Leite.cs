using System;

/*
Esta é uma classe concreta para o uso do contexto
 */
namespace Decorator_Pattern
{
    public class Leite : BebidaDecorator
    {

        public Leite(Bebida bebida) 
            : base(bebida) 
        {

        }

        public override Double preco()
        {
           return base.preco() + 1;
        }
    }
}
