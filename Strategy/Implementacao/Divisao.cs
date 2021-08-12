using StrategyPattern.Strategy.Interface;

namespace StrategyPattern.Strategy
{
    public class Divisao : IOperacao
    {
        public double Calcular(double valor1, double valor2)
        {
            // TODO: tratar divisão por 0
            return valor1 / valor2;
        }
    }
}