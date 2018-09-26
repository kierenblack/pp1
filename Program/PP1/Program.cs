/***************************************
 * Mini Project # 2                    *
 * Sabi, Jae, Kieran, Charmain, Hong   *
 * Professional Practice # 1           *
 ***************************************/
using System;

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
            Console.WriteLine("Thats good to hear, what brings you here?");
            Console.WriteLine("1 - I just wanted to say hello");
            Console.WriteLine("2 - I just wanted to share feedback");
            Console.WriteLine("3 - I want extra material for my lectures");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);
            switch (response)
            {
                case '1':
                    Yes1();
                    break;
                case '2':
                    Yes2();
                    break;
                case '3':
                    Yes3();
                    break;
                default:
                    break;
            }

        }

        static void ResponseNo()
        {
            // Structure for No starts here
            Console.WriteLine("You answered No");
        }

        static void Yes1()
        {
            Console.Clear();
            Console.WriteLine("Hello :)");
        }

        static void Yes2()
        {

        }

        static void Yes3()
        {

        }

        static void No1()
        {

        }

        static void No2()
        {

        }

        static void No3()
        {

        }

        static void No4()
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
