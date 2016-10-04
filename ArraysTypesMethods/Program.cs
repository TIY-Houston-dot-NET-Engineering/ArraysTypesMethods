using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTypesMethods
{
    class Program
    {
        public enum Fruit
        {
            banana = 0,
            orange = 1,
            apple = 2,
            peach = 3
        }

        public enum Role
        {
            admin = 1,
            student = 2
        }

        static void Main(string[] args)
        {
            // string name = "Hello, my name is" + Console.ReadLine()) + ".";
            // Console.WriteLine(name);
            // Console.WriteLine(name);
            // Console.WriteLine("Hello, my name is {0}.", Console.ReadLine());
            // Console.WriteLine("I am from {0}.", Console.ReadLine());

            // string name = String.Format("Hello my name is {0}", Console.ReadLine());
            // string name2 = $"Hello my name is {Console.ReadLine()}.";
            //string name2 = $"Hello my name is Matt.     ";
            //string str3 = $"{name2} I like coffee.";
            //Console.WriteLine(str3);

            //Console.WriteLine(str3.Length);

            //Console.WriteLine(String.Compare("Matt", "Matthew"));
            //Console.WriteLine("Matthew".IndexOf("hew"));
            //Console.WriteLine("Matthew".IndexOf("hw"));

            //string names = "Matthew Mark Harrison Greenley Brutus John ALbert Wesley Snipes Harambe LeBron";
            //Console.WriteLine(
            //    names.Substring(0, names.Length / 2).Replace(" ", "__")
            //    +
            //    names.Substring(names.Length / 2)
            //);

            //string names = "Matthew Mark Harrison Greenley Brutus John ALbert Wesley Snipes Harambe LeBron";
            //Console.WriteLine("Who are you?");
            //string me = Console.ReadLine();
            //char[] delim = { ' ' };
            //string[] eachName = names.Split(delim);
            //Console.WriteLine(eachName);
            /*my name is on the list*/
            //if (names.IndexOf(me) != -1)
            //{
            //    Console.WriteLine("Access granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Denied.");
            //}

            //int fruit = Int32.Parse(Console.ReadLine());
            //Fruit f = Fruit.banana;
            //Fruit g = Fruit.apple;

            //Console.WriteLine("Please login; are you an admin (1) or a student (2)?");
            //int input;
            //Int32.TryParse(Console.ReadLine(), out input);
            //Role chosenRole = (Role)input;
            //if(chosenRole == Role.admin)
            //{
            //    // success - admin
            //} else
            //{
            //    // success - student
            //}

            AskForName(1);

            Console.ReadLine();

            //var name = new FullName { first = "Mary Lou" };
            //FullName[] = { name };

        }

        public static void AskForName(int num)
        {
            Console.WriteLine("What is your name? {0}", num);
            string name = Console.ReadLine();
            if(name != "exit")
            {
                // handle the name
                // then try again
                AskForName(num + 1);
            }
            // do nothing
        }
    }

    class FullName
    {
        public string first;
        public string last;
    }
}
