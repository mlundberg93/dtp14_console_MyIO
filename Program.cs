using System.Runtime.InteropServices;

namespace dtp14_console_MyIO
{
    /// <summary>
    /// class <b>MyIO</b> - IO facilities for console programming
    /// </summary>
    public class MyIO
    {
        public static bool YesNoInput(string prompt)
        {
            
            do
            {
                Console.Write($"{prompt}: ");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "yes" || userInput == "y")
                {
                    return true;
                }
                else if (userInput == "no" || userInput == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input, please type Yes/y or No/n.\n");
                }
            } while (true);
            
        }
        public static double DoubleInput(string prompt = "write a double number")
        {
            do
            {
                Console.Write($"{prompt}: ");
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Not a double number, please try again!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Number too large or too small, please try again!");
                }
            } while (true);
        }
        public static string StringInput(string prompt)
        {
            Console.Write("> ");
            return Console.ReadLine();
        }
        /// <summary>
        /// <b>Greet</b> - asks the user for a name and greets him/her
        /// </summary>
        static public void Greet()
        {
            Console.Write("What's your name? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
        /// <summary>
        /// <b>IntInput</b> - asks for an integer number by writing
        /// a prompt, keeps asking till the integer is valid
        /// </summary>
        /// <param name="prompt">the prompt string, defaults to "write an integer"</param>
        /// <returns>the integer provided</returns>
        static public int IntInput(string prompt = "write an integer")
        {
            do
            {
                Console.Write($"{prompt}: ");
                try
                {
                    return Int32.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Not an integer number, please try again!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Number too large or too small, please try again!");
                }
            } while (true);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        MyIO.Greet();
                        double ival;
                        Console.WriteLine("Enter values, exit by entering 0!");
                        do
                        {
                            ival = MyIO.DoubleInput("enter value");

                            Console.WriteLine($"ival = {ival}");
                        }
                        while (ival != 0);
            */
            
                MyIO.YesNoInput("Type yes/y or no/n");
                
            
        }
    }
}