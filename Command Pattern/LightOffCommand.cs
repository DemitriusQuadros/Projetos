using System;

namespace Command_Pattern
{

    // this class is a concretion of  interface ICommand and execute the commads in the iot apps
    public class LightOffCommand : ICommand
    {
         private Light light;

         public LightOffCommand (Light _light)
         {
            this.light = _light;
         }

         public void Execute()
         {
            this.light.Off();
         }
    }
}
