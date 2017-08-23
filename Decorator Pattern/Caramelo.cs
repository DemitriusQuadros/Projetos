using System;

/*
Esta é uma classe concreta para o uso do contexto
 */
namespace Decorator_Pattern
{
    public class Caramelo : BebidaDecorator
    {

        public Caramelo(Bebida bebida)
            : base(bebida)
        {

        }
        public override Double preco()
        {
            return base.preco() + 3;
        }
    }
}
