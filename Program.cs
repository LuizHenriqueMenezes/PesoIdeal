using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular seu peso ideal, para isso: ");

            Console.WriteLine(" Digite sua altura em metros: ");
            double altura;
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu sexo, usando M para masculino e F para feminino: ");
            bool sexo;
            sexo = Console.ReadLine().ToUpper() == "M";

            double idealMasc, idealFem;
            idealFem = altura * 62.1 - 44.7;
            idealMasc = altura * 72.7 - 58;

            if (sexo)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;   
                Console.WriteLine($"Seu peso ideal é {idealMasc:N2} kg.");
                // Ia colocar N1 para ficar apenas uma casa depois da vírgula mas o resultado arredondava 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;       
                Console.WriteLine($"Seu peso ideal é {idealFem:N2} kg.");
            }
            Console.ResetColor();

            Console.WriteLine("Obrigado por usar o programa :D");


        }
    }
}
