using System.Text.RegularExpressions;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Not a number");
                }
            }
        }
    }
}
