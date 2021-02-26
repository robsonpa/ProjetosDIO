using System;
using System.Globalization;


namespace aumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario, percentual;
            //salario = Convert.ToDouble(Console.ReadLine());
            //CultureInfo.InvariantCulture,
            //salario = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));            
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Double.TryParse(Console.ReadLine(), out salario);

            //insira os valores corretos de acordo com o enunciado

            if (salario < 0.00) 
            { 
              novoSalario = 0; percentual = 0.00; reajuste = 0.00;
              
              //Console.WriteLine("Informe um valor válido!");
              Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F", CultureInfo.InvariantCulture));
              Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F", CultureInfo.InvariantCulture));
              Console.WriteLine("Em percentual: {0:0} %", percentual);
              
            }
            else if(salario == 0.00){
              
               novoSalario = 0; percentual = 15; reajuste = 0.00;
              
              //Console.WriteLine("Informe um valor válido!");
              Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F", CultureInfo.InvariantCulture));
              Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F", CultureInfo.InvariantCulture));
              Console.WriteLine("Em percentual: {0:0} %", percentual);
              
            }
            else if(salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15; 
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if(salario > 2000.00)
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0:0} %", percentual);        
            }
        }
        
    }
}