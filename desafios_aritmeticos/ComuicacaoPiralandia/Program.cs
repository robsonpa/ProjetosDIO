using System;

namespace ComuicacaoPiralandia
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] arr = n.ToCharArray();
            Array.Reverse(arr);

            string v = new string(arr);
            Console.WriteLine(v);
        }
    }
}
