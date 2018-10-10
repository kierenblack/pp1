/***************************************
 * Mini Project # 2                    *
 * Sabi, Jae, Kieren, Charmain, Hong   *
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
                Console.WriteLine("I am sorry to hear that you are not enjoying your course. What seems to be the problem?");
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
            //END
            }

            static void Yes2()
            {
                string name = "", feedback = "";
                Console.Clear();
            Console.WriteLine("Okay. Please enter the teachers name and then your message?");
            Console.WriteLine("Please enter the name of the teacher.Then your feedback in next sentence");
            string temp = Console.ReadLine();
                string[] sentence = temp.Split('.');
                name = sentence[0];
                feedback = sentence[1];
                Yes2_1(name, feedback);
            }

            static void Yes2_1(string name, string feedback)
            {
                Console.Clear();
                Console.WriteLine("I will speak to " + name + " and let them know that you said, " + feedback);
            //END
            }

            static void Yes3()
            {
                Console.Clear();
                Console.WriteLine("Which course you want the extra material for?");
                Console.WriteLine("1 - Maths");
                Console.WriteLine("2 - Professional Practices");
                Console.WriteLine("3 - Devices and Platforms");
                Console.WriteLine("4 - Programming");
                char response = Convert.ToChar(Console.ReadKey().KeyChar);
                switch (response)
                {
                    case '1':
                        Yes3_1("Maths");
                        break;
                    case '2':
                        Yes3_1("Professional Practices");
                        break;
                    case '3':
                        Yes3_1("Devices and Platforms");
                        break;
                    case '4':
                        Yes3_1("Programming");
                        break;
                    default:
                        break;
                }
            }

            static void Yes3_1(string subject) // reads subject
            {
                Console.Clear();
                Console.WriteLine("I will organize extra material for " + subject);
                Console.WriteLine("\nYou can pick the extra material tomorrow afternoon at 11am from customer service office on level - 3.");
            //END
            }

            static void No1()
            {
                Console.Clear();
                Console.WriteLine("What course do you not understand?");
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
                    //END
                }
            }

            static void No2()
            {
                Console.Clear();
                Console.WriteLine("Which class is boring for you?");
                Console.WriteLine("1 - Maths");
                Console.WriteLine("2 - Professional Practices");
                Console.WriteLine("3 - Devices and Platforms");
                Console.WriteLine("4 - Programming");
                char response = Convert.ToChar(Console.ReadKey().KeyChar);
                switch (response)
                {
                    case '1':
                        No2_1("Maths");
                        break;
                    case '2':
                        No2_1("Professional Practices");
                        break;
                    case '3':
                        No2_1("Platforms and Devices");
                        break;
                    case '4':
                        No2_1("Programming");
                        break;
                    default:
                        break;
                }
            }

            static void No2_1(string subject)
            {
                Console.Clear();
                Console.WriteLine("I am sorry to hear that you are finding " + subject + " boring. I will ask your teacher to assign you some advanced material.");
            //END
            }

            static void No3()
            {
                // having trouble with
                Console.Clear();
                Console.WriteLine("Is this problem personal or course related?");
                Console.WriteLine("1 - Personal");
                Console.WriteLine("2 - Course Related");
                char response = Convert.ToChar(Console.ReadKey().KeyChar);
                switch (response)
                {
                    case '1':
                        No3_1();
                        break;
                    case '2':
                        No3_2();
                        break;
                    default:
                        break;
                }
            }

            static void No3_1()
            {
                // personal problem
                Console.Clear();
                Console.WriteLine("I will make an appointment for you to talk to student services.");
            }

            static void No3_2()
            {
                // course related problem
                Console.Clear();
                Console.WriteLine("Would you like to talk to student support or the class teacher?");
                Console.WriteLine("1 - Student Support");
                Console.WriteLine("2 - Class Teacher");
                char response = Convert.ToChar(Console.ReadKey().KeyChar);
                switch (response)
                {
                    case '1':
                        No3_2_1();
                        break;
                    case '2':
                        No3_2_2();
                        break;
                    default:
                        break;
                }
            }

            static void No3_2_1()
            {
                // course related problem -> refer to student support
                Console.Clear();
                Console.WriteLine("I will make an appointment for you to talk to student support");

            }

            static void No3_2_2()
            {
                // course related problem -> refer to class teacher
                Console.Clear();
                Console.WriteLine("I will make an appointment for you to talk to a class teacher");
            //END
            }

            static void No4()
            {
                Console.Clear();
                Console.WriteLine("Who is harassing you?");
                string name = Console.ReadLine();
                No4_1(name);
            }

            static void No4_1(string name)
            {
                Console.Clear();
                Console.WriteLine("I am sorry to hear you are getting harassed by " + name + ". Bullying/Harassment is not acceptable at Otago Polytechnic. Would you like me to talk to " + name + " or Student Support Team?");
                Console.WriteLine("1 - " + name + " ");
                Console.WriteLine("2 - Student Support Team");
                char response = Convert.ToChar(Console.ReadKey().KeyChar);
                switch (response)
                {
                    case '1':
                        No4_1_1(name);
                        break;
                    case '2':
                        No4_1_2();
                        break;
                    default:
                        break;
                }
            }


            static void No4_1_1(string name)
            {
                Console.Clear();
                Console.WriteLine("I will Talk to " + name + " about this bullying behaviour.");
                Console.ReadLine();
            }

            static void No4_1_2()
            {
                Console.Clear();
                Console.WriteLine("I will arrange an appointment for you to talk to student services to resolve the matter.");
            //END
            }
             
            static void No4_2()
            {
                Console.Clear();
                Console.WriteLine("It's absolutely fine if you do not want to mention their name here. I will arrange an appointment for you to talk to student services to resolve the matter.");
            //END
            }
        }
    }
