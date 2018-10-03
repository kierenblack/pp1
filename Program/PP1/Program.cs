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
            Console.Clear();
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
            Console.Clear();
            Console.WriteLine("I am sorry to hear. What seems to be the problem?");
            Console.WriteLine("1 - I don’t understand…");
            Console.WriteLine("2 - Class is boring");
            Console.WriteLine("3 - I’m having trouble with…");
            Console.WriteLine("4 - I’m getting bullied");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);
            switch (response)
            {
                case '1':
                    No1();
                    break;
                case '2':
                    No2();
                    break;
                case '3':
                    No3();
                    break;
                case '4':
                    No4();
                    break;
                default:
                    break;
            }
        }

        static void Yes1()
        {
            Console.Clear();
            Console.WriteLine("Okay. Hello, nice to see you!");
        }

        static void Yes2()
        {
            Console.Clear();
            Console.WriteLine("Okay. What do you want to say and to what teacher?");
        }

        static void Yes2_1(string name, string feedback)
        {

        }

        static void Yes3()
        {
            Console.Clear();
            Console.WriteLine("Which class?");
        }

        static void Yes3_1(int subject)
        {
            Console.Clear();
            Console.WriteLine("I will organize extra material for that class");
        }

        static void No1()
        {
            Console.Clear();
            Console.WriteLine("What class or subject do you not understand?");
            Console.WriteLine("1 - Maths");
            Console.WriteLine("2 - Professional Practices");
            Console.WriteLine("3 - Devices and Platforms");
            Console.WriteLine("4 - Programming");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);
            switch (response)
            {
                case '1':
                    No1_1("Maths");
                    break;
                case '2':
                    No1_1("Professional Practices");
                    break;
                case '3':
                    No1_1("Devices and Platforms");
                    break;
                case '4':
                    No1_1("Programming");
                    break;
                default:
                    break;
            }
        }

        static void No1_1(string subject)
        {
            Console.Clear();
            Console.WriteLine("I am sorry to hear you are having problems in " + subject + ". How would you like me to help?");
            Console.WriteLine("1 - Extra Material");
            Console.WriteLine("2 - Student Support");
            Console.WriteLine("3 - Teacher Support");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);
            No1_1_1(response);
        }

        static void No1_1_1(char option)
        {
            Console.Clear();
            switch (option)
            {
                case '1':
                    Console.WriteLine("I will organise some extra material for you.");
                    break;
                case '2':
                    Console.WriteLine("I will make an appoint with student support for you.");
                    break;
                case '3':
                    Console.WriteLine("I will make an appointment for you to talk to your teacher.");
                    break;
                default:
                    break;
            }
        }

        static void No2()
        {

        }

        static void No2_1()
        {

        }

        static void No2_1_1(int subject)
        {

        }

        static void No3()
        {

        }

        static void No3_1()
        {

        }

        static void No3_1_1(int choice)
        {

        }

        static void No4()
        {
            Console.Clear();
            Console.WriteLine("Who is harassing you?");
        }

        static void No4_1()
        {
            //Bullied with name or ss
        }

        static void No4_1_1(int choice, string name)
        {
            //Bullied with name, talk
        }

        static void No4_1_2(int choice, string name)
        {
            Console.Clear();
            Console.WriteLine("I will arrange an appointment for you to talk to student services.");
        }

        static void No4_2()
        {
            //bullied not saying
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
