using System;
using System.Collections.Generic;

/*
Esta interface representa uma classe que irá ser 
observada, ou seja é uma implentação de uma classe IObservable
 */
namespace Observable_pattern
{
    public interface IConcentrador
    {
        void Adicionar(IFilial filial);
        void Remover(IFilial filial);
        void Notificar();
        List<int> GetState();
    }
}
