using System;
using System.Collections.Generic;

/*
Implementação concreta de um objeto observado
 */

namespace Observable_pattern
{
    public class Concentrador : IConcentrador
    {
        public List<int> produtos { get; set; }
        public List<IFilial> filiais { get; set; }

        public Concentrador()
        {
            this.produtos = new List<int>();
            this.filiais = new List<IFilial>();
        }
        public void Adicionar(IFilial filial)
        {
            this.filiais.Add(filial);
        }

        public void Remover(IFilial filial)
        {
            this.filiais.Remove(filial);
        }     
           
        public void Notificar()
        {
            foreach (var filial in this.filiais)
            {
                filial.Atualizar();
            }
        }

        public void AddProduto()
        {   
            Random random = new Random(2012);
            this.produtos.Add(random.Next());
        }

        public List<int> GetState()
        {
            return this.produtos;
        }
    }
}
