using System;

namespace Command_Pattern
{

    // this interface is responsable for define the commands has be called by the invoker
    public interface ICommand
    {
        void Execute();
    }
}
