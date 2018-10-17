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
        public static bool ran = false;
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            if (!ran) //Only run the first time the program is run
            {
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                }
                //Display intro screen
                displayCentre("**************************************************");
                displayCentre("*                                                *");
                displayCentre("* Welcome to the AI Teacher program degigned by: *");
                displayCentre("* Sabi, Jae, Kieren, Charmain and Hong           *");
                displayCentre("*                                                *");
                displayCentre("* Press any key to begin                         *");
                displayCentre("*                                                *");
                displayCentre("**************************************************");
                Console.ReadLine();
                ran = true;
            }


            Console.Clear();
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
            Console.ReadLine();
            Main();


        }

        static void displayCentre(string s) //Centre the message in the middle of the screen
        {
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
        }

        static void ResponseYes()
        {
            //If the first response is yes
            Console.Clear();
            Console.WriteLine("Thats good to hear. What brings you here?");
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
            Console.WriteLine("I am sorry to hear that you are not enjoying your classes. What seems to be the problem?");
            Console.WriteLine("1 - I don’t understand…");
            Console.WriteLine("2 - Class is boring");
            Console.WriteLine("3 - I’m having trouble with…");
            Console.WriteLine("4 - I’m getting bullied.");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);
            switch (response) //Branches based on response
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
            Console.WriteLine("Okay. Please enter the teachers name and then your feedback?");
            Console.WriteLine("Please enter the name of the teacher, then your feedback (name, feedback)");
            string temp = Console.ReadLine();
            string[] sentence = temp.Split(','); //Splits the sentence at the ',' into name and feedback
            name = sentence[0]; //Grabs the first part of the sentence
            feedback = sentence[1]; //Grabs the second part of the sentence
            Yes2_1(name, feedback);
        }

        static void Yes2_1(string name, string feedback) //reads the name and the feedback
        {
            Console.Clear();
            Console.WriteLine("I will speak to " + name + " and let them know that you said, " + feedback); //Uses both name and feedback
            //END
        }

        static void Yes3()
        {
            Console.Clear();
            Console.WriteLine("Which course do you want the extra material for?");
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
            //If the response is no from the first question
            Console.Clear();
            Console.WriteLine("What course do you not understand?");
            Console.WriteLine("1 - Maths");
            Console.WriteLine("2 - Professional Practices");
            Console.WriteLine("3 - Devices and Platforms");
            Console.WriteLine("4 - Programming");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);
            switch (response) //Passes a string to the next question
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

        static void No1_1(string subject) //reads the subject from the previous selection
        {
            Console.Clear();
            Console.WriteLine("I am sorry to hear you are having problems in " + subject + ". How would you like me to help?");
            Console.WriteLine("1 - Extra Material");
            Console.WriteLine("2 - Student Support");
            Console.WriteLine("3 - Teacher Support");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);
            No1_1_1(response); //Send the response to the next question
        }

        static void No1_1_1(char option) //Reads the option
        {
            Console.Clear();
            switch (option) //Switches based on the previous selection
            {
                case '1':
                    Console.WriteLine("I will organise some extra material for you.");
                    break;
                case '2':
                    Console.WriteLine("I will make an appointment with student support for you.");
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
            char response = Convert.ToChar(Console.ReadKey().KeyChar); //ReadKey is used so the user doesn't have to press enter
            switch (response) //Passses the response to the next question/method
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

        static void No2_1(string subject) //Reads teh subject
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
            switch (response) //branches depending on selection
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
            Console.ReadLine();

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

        static void No4_1(string name) //Reads the name
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


        static void No4_1_1(string name) //Reads the name
        {
            Console.Clear();
            Console.WriteLine("I will talk to " + name + " about this bullying behaviour.");
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
