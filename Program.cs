using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Simples \n");
                Console.WriteLine("Escolha a operação: \n");

                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");

                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 5)
                {
                    break; // Sair do loop e encerrar o programa
                }

                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (escolha)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero!");
                            continue; // Continuar para o próximo loop
                        }
                        break;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        continue; // Continuar para o próximo loop
                }

                Console.WriteLine("Resultado: \n " + resultado);
            }
        }
    }
}
