using System;
/*
Desenvolvido por : Demitrius R. Quadros
Data :  09/08/2017

Este projeto .net core tem por objetivo exemplificar
o funcionamento do Desing Pattern (padrão de projeto)
Strategy de forma aplicada*/
namespace Strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispositivo dispositivo = new Dispositivo();
            //Solicita para o usuário qual o dispositivo que ele esta usandp
            Console.WriteLine("Ola defina o seu dispositivo :");
            Console.WriteLine("1 - Phone ");
            Console.WriteLine("2 - Tablet ");
            Console.WriteLine("3 - Desktop ");
            var retorno = Console.ReadLine();
            //adiciona o comportamento conforme opção do usuário
            switch (retorno)
            {
                case "1" : 
                    dispositivo.view = new ViewPhone();
                    break;
                case "2" : 
                    dispositivo.view = new ViewTablet();
                    break;
                case "3" : 
                    dispositivo.view = new ViewDesktop();
                    break;
                default: 
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            //Exibe resultado do comportamento
            Console.WriteLine(dispositivo.GetView());
        }
    }
}
