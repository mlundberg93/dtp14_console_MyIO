namespace dtp14_console_MyIO
{
    public class MyIO
    {
        static public void Greet()
        {
            Console.Write("What's your name? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
        static public int IntInput(string prompt)
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
            MyIO.Greet();
            int ival;
            Console.WriteLine("Enter values, exit by entering 0!");
            do
            {
                ival = MyIO.IntInput("enter value");

                Console.WriteLine($"ival = {ival}");
            }
            while (ival != 0);
        }
    }
}