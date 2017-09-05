using System;
using System.Collections.Generic;

namespace Singleton_Pattern
{
    class Program
    {

        public static List<Client> clients;
            
        private static void ShowClients()
        {            
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine(i + " - " + clients[i].name);
            }
        }

        public static void AddClients()
        {
            clients = new List<Client>();
            clients.Add(new Client {name = "Jose"});
            clients.Add(new Client {name = "Maria"});
            clients.Add(new Client {name = "Vanessa"});
        }

        static void Main(string[] args)
        {
        
            String op = " ";
            Console.WriteLine("Bem vindo ao chat");
            Console.WriteLine("Digite seu nome de usuario...");
            String nome = Console.ReadLine();
            Client me = new Client {name = "Me"};
            AddClients();
            while (op != "N")
            {
                Console.Clear();
                Console.WriteLine(" Deseja enviar uma mensagem ? S/N");
                op = Console.ReadLine();

                if (op == "S")
                {
                    ShowClients();
                    Console.WriteLine("Informe o cliente que deseja consultar (indice).");
                    var ind = Console.ReadLine();
                    var messager = Messager.GetInstance();

                    Console.WriteLine("Digite a mensagem...");
                    var mensagem = Console.ReadLine();
                    Console.WriteLine(messager.Send(mensagem, me, clients[int.Parse(ind)]));
                    Console.ReadLine();
                } 

                
            }
        }
    }
}
