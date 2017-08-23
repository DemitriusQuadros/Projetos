using System;

/*
Esta é uma classe concreta para o uso do contexto
 */
namespace Decorator_Pattern
{
    public class Achocolatado : BebidaDecorator
    {
        public Achocolatado(Bebida bebida)
            : base(bebida)
        {
        }
        public override Double preco()
        {
            return base.preco() + 2;
        }

    }
}
