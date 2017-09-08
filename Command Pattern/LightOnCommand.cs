using System;

namespace Command_Pattern
{

    // this class is a concretion of  interface ICommand and execute the commads in the iot apps
    public class LightOnCommand : ICommand
    {
     
        private Light light;

         public LightOnCommand (Light _light)
         {
            this.light = _light;
         }

         public void Execute()
         {
            this.light.On();
         }
    }
}
