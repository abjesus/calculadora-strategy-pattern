using StrategyPattern.Strategy.Interface;

namespace StrategyPattern.Strategy
{
    public class Soma : IOperacao
    {
        public double Calcular(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }
}