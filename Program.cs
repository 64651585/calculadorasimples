using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("====================== Minha Calculadora ======================");
            Console.WriteLine("===============================================================");
            Console.WriteLine(""); Console.WriteLine("");

            var op = "";

            do
            {
                Console.WriteLine("Escolha uma opção no menu: ");
                Console.WriteLine("1 - soma");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 - divisão");
                Console.WriteLine("4 - multiplicação");
                Console.WriteLine("0 - para sair");
                op = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Digite o primeiro valor: ");
                var numA = Console.ReadLine();
                double num1 = double.Parse(numA);

                Console.WriteLine("Digite o segundo valor: ");
                var numB = Console.ReadLine();
                double num2 = double.Parse(numB);

                switch (op)
                {
                    case "1":
                        double a = num1 + num2;
                        Console.WriteLine("\nO resultado da soma é: " + a + "\n");
                        break;
                    case "2":
                        double b = num1 - num2;
                        Console.WriteLine("\nO resultado da subtração é: " + b + "\n");
                        break;
                    case "3":
                        double c = num1 / num2;
                        Console.WriteLine("\nO resultado da divisão é: " + c + "\n");
                        break;
                    case "4":
                        double d = num1 * num2;
                        Console.WriteLine("\nO resultado da multiplicação é: " + d + "\n");
                        break;
                    default:
                        Console.WriteLine("Fechando programa...");
                        break;
                }
            }
            while(op != "0");
        }
    }
}
