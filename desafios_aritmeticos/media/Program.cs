using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double media;
            //double peso;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            
            //peso = 3.5 + 7.5;
            //calcule a media conforme o enunciado
            media = ((A * 3.5) + (B * 7.5)) / 11;
            
            Console.WriteLine($"MEDIA = {(string.Format("{0:0.00000}",media))}");
        }
    }
}
