using System;

namespace Command_Pattern
{

    // This class is responsable to invoke the commands
    // with the invoker you can turn the linked IOT apps
    // on/off and change de intansity of power in this apps
    public class Invoker
    {
        private ICommand lightOn;
        private ICommand lightOff;

        public Invoker(ICommand on, ICommand off)
        {
            lightOn = on;
            lightOff = off;
        }

        public void ClickOn()
        {
            lightOn.Execute();
        }

        public void ClickOff()
        {
            lightOff.Execute();
        }

    }
}
