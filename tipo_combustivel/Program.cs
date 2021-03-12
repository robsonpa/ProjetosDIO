using System;

namespace tipo_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            //string Continue;

            do
            {                 
                                  
                int entrada = Convert.ToInt32(Console.ReadLine());
                
                switch (n)
                {
                    case 1: // Alcool
                    n++;
                     Console.WriteLine("MUITO OBRIGADO");
                     Console.WriteLine("Alcool: "+ n);
                    case 2: // Gasolina
                    n++;
                     Console.WriteLine("Gasolina: "+ n);
                    case 3: // Diesel
                    n++;
                     Console.WriteLine("Diesel: "+ n);   
                    case 4: // Fim
                        Console.Clear();
                        break;
                    default:                       
                        continue;
                }
                
                //Continue = Console.ReadLine();
            }
       
          while (n > 5);
        }
    }
}
