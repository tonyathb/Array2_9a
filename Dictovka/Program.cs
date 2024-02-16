using System.Globalization;

namespace Dictovka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Брои На ваведени числа:");
            byte n = byte.Parse(Console.ReadLine());

            byte countWords = 0;
            string result = "";
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write("Vavedi duma: ");
            //    string word = Console.ReadLine();
            //    countWords++;
            //    //result += word + ", " ;
            //    result = result + word + ", " ;
            //}


            //do
            //{
            //    Console.Write("Vavedi duma: ");
            //    string word = Console.ReadLine();
            //    countWords++;
            //    result = result + word + ", ";
            //} while (countWords < n);
            while (countWords < n)
            {
                Console.Write("Vavedi duma: ");
                string word = Console.ReadLine();
                countWords++;
                result = result + word + ", ";
            } 

            Console.WriteLine(countWords);
            Console.WriteLine(result);
        }
    }
}
