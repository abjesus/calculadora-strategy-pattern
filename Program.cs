using System;
using StrategyPattern.Strategy;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora - StrategyPattern");

            Console.WriteLine("Informe um valor");
            var valor1 = Console.ReadLine();

            Console.WriteLine("Informe outro valor");
            var valor2 = Console.ReadLine();

            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - multiplcação");

            var operacao = Console.ReadLine();

            var calculadora = new CalculadoraContext(new Soma());

            switch (operacao)
            {
                case "1": // soma
                    break;
                case "2": // subtração
                    calculadora.SetOperacao(new Subtracao());
                    break;
                case "3": // divisão
                    calculadora.SetOperacao(new Divisao());
                    break;
                case "4": // multiplicação
                    calculadora.SetOperacao(new Multiplicacao());
                    break;
                default:
                    Console.WriteLine("Operação não permitida!");
                    Console.WriteLine();
                    Main(args);
                    return;
            }

            calculadora.Calcular(double.Parse(valor1), double.Parse(valor2));

            Console.ReadLine();
        }
    }
}
