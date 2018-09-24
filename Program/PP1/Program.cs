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
