using System;

/*
Desenvolvido por Demitrius Ruan Quadros

Este programa tem por objetivo exemplificar a 
implementação de um programa utilizando o desing patter
Observer
 */

namespace Observable_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Concentrador concentrador = new Concentrador();
            String op = " ";
            int indFilial = 0;
            while (op != "sair")
            {
                Console.Clear();
                Console.WriteLine("Escolha a opção");
                Console.WriteLine("1 - Adicionar novo produto");
                Console.WriteLine("2 - Adicionar nova filial");
                Console.WriteLine("3 - Visualizar produtos por filial");
                Console.WriteLine("4 - Visualizar produtos filial especifica");
                Console.WriteLine("5 - Sair");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":   concentrador.AddProduto();
                                break;
                    case "2":   indFilial++;
                                concentrador.Adicionar(new Filial(concentrador, "Filial "+indFilial));
                                break;
                    case "3":   VisualizarProdutosFiliais(ref concentrador);
                                break;
                    case "4":   VisualizarProdutosFilial(ref concentrador);
                                break;
                    case "5":   op = "sair";
                                break;
                }
                Console.ReadKey();
            }
        }

        public static void VisualizarProdutosFiliais(ref Concentrador concentrador)
        {

            foreach (var filial in concentrador.filiais)
            {
                Console.WriteLine("Produtos para a filial "+filial.nome());
                foreach (var produto in filial.produtos())
                {
                    Console.WriteLine("Produto + " + produto);
                }
            }
        }

        public static void VisualizarProdutosFilial(ref Concentrador concentrador)
        {
            int indFilial = 0;
            Console.WriteLine("Informe a filial que deseja consultar");
            indFilial = int.Parse(Console.ReadLine());

            var filial = concentrador.filiais[indFilial-1];
            if (filial != null)
            {
                Console.WriteLine("Produtos da filial " + filial.nome());
                //Faz o pull das informações da classe antes de mostrar
                //Os produtos para o usuário
                filial.Atualizar();
                foreach (var produto in filial.produtos())
                {
                    Console.WriteLine("Produto " + produto);
                }
            }
            else
            {
                Console.WriteLine("Não foi possível");
            }
        }
    }
}
