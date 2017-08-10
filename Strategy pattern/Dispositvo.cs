using System;
/*

A Classe Dispositivo representa o Cliente do padrão strategy
A Interface IView irá receber os comportamentos conforme passado
como valor para instância da classe.
*/
public class Dispositivo

{
    public IView view { get; set;}

    //O comportamento desse metodo poder ser modificado
    //Conforme a estratégia que será passada para interface
    //que esta sendo utilizada com atributo desta classe
    public String GetView()
    {
        return view.GetView();
    }
}