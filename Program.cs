using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            Console.Write("DELTA ROOT> Escolha uma operação : ");
            string opcaoInput = Console.ReadLine();
            string opcao = opcaoInput ?? ""; // Se opcaoInput for nulo, atribuir uma string vazia

            if (opcao == "0")
            {
                Console.WriteLine("DELTA ROOT> Saindo da calculadora. Até logo!");
                break;
            }

            if (!string.IsNullOrEmpty(opcao) && IsOpcaoValida(opcao))
            {
                Console.Write("DELTA ROOT> Digite o primeiro número: ");
                string num1Input = Console.ReadLine();
                double num1 = Convert.ToDouble(num1Input ?? "0"); // Se num1Input for nulo, atribuir "0"

                Console.Write("DELTA ROOT> Digite o segundo número: ");
                string num2Input = Console.ReadLine();
                double num2 = Convert.ToDouble(num2Input ?? "0"); // Se num2Input for nulo, atribuir "0"

                double resultado = Calcular(opcao, num1, num2);

                Console.WriteLine($"DELTA ROOT> Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("DELTA ROOT> Opção inválida. Tente novamente.");
            }

            Console.WriteLine();
        }
    }

    static bool IsOpcaoValida(string opcao)
    {
        return opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4";
    }

    static double Calcular(string opcao, double num1, double num2)
    {
        switch (opcao)
        {
            case "1":
                return num1 + num2;
            case "2":
                return num1 - num2;
            case "3":
                return num1 * num2;
            case "4":
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("DELTA ROOT> Não é possível dividir por zero. Tente novamente.");
                    return 0;
                }
            default:
                return 0;
        }
    }
}