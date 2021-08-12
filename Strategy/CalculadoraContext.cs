using System;
using StrategyPattern.Strategy.Interface;

namespace StrategyPattern.Strategy
{
    public class CalculadoraContext
    {
        private IOperacao _operacao;

        public CalculadoraContext(IOperacao operacao)
        {
            _operacao = operacao;
        }

        public void SetOperacao(IOperacao operacao)
        {
            _operacao = operacao;
        }

        public void Calcular(double valor1, double valor2)
        {
            var resultado = _operacao.Calcular(valor1, valor2);

            Console.WriteLine($"Resultado da operação: {resultado}");
        }
    }
}