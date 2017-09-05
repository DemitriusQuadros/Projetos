using System;

namespace Singleton_Pattern
{
    // This is a singleton class, she has a only instance
    // and this instance is responsable to send de messages
    // through the application.
    public class Messager
    {
        private static Messager instance;

        // The construtctor of the class is private
        // and just accessble for the class
        private Messager()
        {

        }

        // This method is responsable for create and 
        // control the instance of the class
        public static Messager GetInstance()
        {
            if (instance == null)
            {
                instance = new Messager();
            }
            return instance;
        }

        // Return the message send by the application
        public String Send(String message, Client sender, Client receiver)
        {
            return "From " + sender.name + " to " + receiver.name + " : " +message;
        }


    }
}
