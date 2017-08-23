using System;


//Este é o decorator do projeto
//Obriga que a classe tenha uma propriedade bebida
namespace Decorator_Pattern
{
    public class BebidaDecorator : Bebida
    {
        protected Bebida bebida;

        public BebidaDecorator(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override Double preco()
        {
            return bebida.preco();
        }

    }
}
