using System;
using Class_01;
using Class_02;

namespace Kindler_Executive_Compiler
{
    class Program
    {
        public static string cmd_init = "cmd";
        public static string cmd_help = "help";
        public static string cmd_exit = "exit";
        public static string key_return = "enter";
        public static string redlin = "";

        public static bool active = true;

        static void Main()
        {
            C.W3("To initiate a command, type: /{0}\n", cmd_init, key_return);
            C.W3("To access the help page, type: /{0}", cmd_help, key_return);
            C.W2("To exit KEC, type: /{0}, or !", cmd_exit);
            redlin = Cv.CRL();
            Console.Clear();
            C.W3("To access the help page, type: /{0}", cmd_help, key_return);
            do
            {
                redlin = Cv.CRL();
                if (redlin == "/cmd")
                {
                    C.W("\nERROR: command not set up yet");
                }
                else
                if (redlin == "/help")
                {
                    C.W("\nCommands:\n\n -cmd\n -help\n -exit");
                }
                else
                if (redlin == "/exit" || redlin == "!")
                {
                    active = false;
                }
                else
                if (redlin != "")
                {
                    C.W("ERROR: invalid command!");
                }
                else
                {
                    Console.Clear();
                    C.W3("To access the help page, type: /{0}", cmd_help, key_return);
                }
            } while (active == true);
        }
    }
}
