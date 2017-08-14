using System;
using System.Collections.Generic;
/* Implementação concreta de um observador*/
namespace Observable_pattern
{
    public class Filial : IFilial
    {
        Concentrador concentrador { get; set; }
        List<int> _produtos;
        String _nome;

        public Filial(Concentrador concentrador, String nome)
        {
            this.concentrador = concentrador;
            this._produtos = concentrador.produtos;
            this._nome = nome;
        }

        public void Atualizar()
        {
            this._produtos = concentrador.produtos;
        }

        public String nome()
        {
            return _nome;
        }

        public void nome(String a)
        {
            this._nome = a;
        }
        public List<int> produtos()
        {
            return _produtos;
        }
    }
}
