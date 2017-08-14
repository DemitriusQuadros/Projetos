using System;
using System.Collections.Generic;
/*
esta interface representa a implementação de um observador
ou seja um IObserve, ela sera notificada toda vez que o objeto
observado for atualizado
 */
namespace Observable_pattern
{
    public interface IFilial
    {
        void Atualizar();
        String nome();
        void nome(String a);
        System.Collections.Generic.List<int> produtos();
        
    }
}
