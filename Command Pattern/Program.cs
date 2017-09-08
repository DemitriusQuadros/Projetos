using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the IOT System");

            String option = String.Empty;
            Light light = new Light();
            Invoker invoker = new Invoker(new LightOnCommand(light), new LightOffCommand(light));
            while (option != "E")
            {
                Console.WriteLine("Press Key O - to turn the light on");
                Console.WriteLine("Press Key F - to turn the light off");
                Console.WriteLine("Press Key E - to Exit the program");
                option  = Console.ReadLine().ToUpper();
                
                switch (option)
                {
                    case "O" :  invoker.ClickOn();
                                break;
                    case "F" :  invoker.ClickOff();
                                break;
                    case "E" :  Console.WriteLine("Exit the program, thank you.");
                                break;
                    default  :  Console.WriteLine("Wrong option.");
                                break;
                }
                
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
