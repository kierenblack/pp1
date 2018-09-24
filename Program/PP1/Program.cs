/***************************************
 * Mini Project # 2                    *
 * Sabi, Jae, Kieran, Charmain, Hong   *
 * Professional Practice # 1           *
 ***************************************/
using System;
using System.Threading;

namespace PP1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello. Are you enjoying your classes?");
            char response = char.ToLower(Console.ReadLine()[0]);
            switch (response)
            {
                case 'y':
                    ResponseYes();
                    break;
                case 'n':
                    ResponseNo();
                    break;
                default:
                    break;
            }

            Console.ReadLine(); // the end

        }

        static void ResponseYes()
        {
            // Structure for Yes starts here
            Console.WriteLine("You answered Yes");
        }

        static void ResponseNo()
        {
            // Structure for No starts here
            Console.WriteLine("You answered No");
        }

        static char Menu1()
        {
            Console.WriteLine("Hello. what brings you here today?");
            Console.WriteLine("Press 1 for issue");
            Console.WriteLine("\t2 for problem");
            Console.WriteLine("\t3 for bullying");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine(response);
            Console.ReadLine();
            return response;
        }
    }
}
