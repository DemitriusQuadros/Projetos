using System;

/*
Demitrius Ruan Quadros 15/08/2017

Este programa visa implementar o padrão de projetos Decorator
 */
namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            String op = "S";
            String op2 = "0"; 
            Cafe cafe = new Cafe();
            BebidaDecorator bebida = new BebidaDecorator(cafe);

            Console.WriteLine("Ola bem-vindo ao sistema de compra automatizada de cafe");
            Console.WriteLine("-------------------------------------------------------");
            Console.ReadLine();
            while (op!="N")
            {
                Console.WriteLine("Deseja adicionar mais alguma coisa a seu cafe? S/N");
                op = Console.ReadLine();
                if (op!="N")
                {
                    Console.WriteLine("1 - Leite");
                    Console.WriteLine("2 - Achocolatado");
                    Console.WriteLine("3 - Caramelo");
                    op2 = Console.ReadLine();
                    switch (op2)
                    {
                        case "1" : 
                                bebida = new Leite(bebida);
                                break;
                        case "2" :
                                bebida = new Achocolatado(bebida);
                                break;
                        case "3":
                                bebida = new Caramelo(bebida);
                                break;
                        default:
                                op = "N";
                                break;
                    }    
                }
                Console.WriteLine("Adicionado com sucesso.");
            }
            Console.Clear();
            Console.WriteLine("O preco do seu cafe e de "+ bebida.preco().ToString());
        }
    }
}
