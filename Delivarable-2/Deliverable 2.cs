using System;

namespace Deliverable_2
    { 
        class Program
        {
            public static int attempt { get; private set; }

            public static void Main(string[] args)
            {
                string bot = "Yes";
                while (bot == "Yes")
                {

                    Console.Write("What do you wish to say to the bot? ");
                    string response = Console.ReadLine();

                    if (response == "hello")
                    {
                        Console.WriteLine("Hi good to see you.");
                    }
                    else if (response == "Hello")
                    {
                        Console.WriteLine("Hi good to see you.");
                    }
                    else if (response == "Hey")
                    {
                        Console.WriteLine("Hi good to see you.");
                    }
                    else if (response == "hey")
                    {
                        Console.WriteLine("Hi good to see you.");
                    }
                    else if (response == "hi")
                    {
                        Console.WriteLine("Hi good to see you.");
                    }
                    else if (response == "Hi")
                    {
                        Console.WriteLine("Hi good to see you.");
                    }
                    else if (response == "bye")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }
                    else if (response == "Bye")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }
                    else if (response == "good bye")
                    {
                        Console.WriteLine("good bye!");
                        break;
                    }
                    else if (response == "Bye bye")
                    {
                        Console.WriteLine("See you later");
                        break;
                    }
                    else if (response == "cya")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }
                    else if (response == "Goodbye")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }
                    else if (response == "sup")
                    {
                        Console.WriteLine("I am good.");
                    }
                    else if (response == "hru")
                    {
                        Console.WriteLine("I am good.");
                    }
                    else if (response == "hru?")
                    {
                        Console.WriteLine("I am good.");
                    }
                    else if (response == "how are you?")
                    {
                        Console.WriteLine("I am good.");
                    }
                    else if (response == "How are you?")
                    {
                        Console.WriteLine("I am good.");
                    }
                    else if (response == "How are you doing?")
                    {
                        Console.WriteLine("I am good.");
                    }
                    else if (response == "how are you doing?")
                    {
                        Console.WriteLine("I am good.");
                    }
                    else if (response == "hello there")
                    {
                        Console.WriteLine("General Kenobi");
                    }
                    else
                        Console.WriteLine("I'm sorry, I don't think I understood what you said.");
                }
                if (attempt == 2)
                {
                    Console.Write("You have already said that. ");
                }
            }
        }
    }

