namespace StockDataSubscriber.Calculators;

public class Volatility
{
    public static double Calculate(double[] prices)
    {
        // Calculate the mean of the prices
        double mean = prices.Average();

        // Calculate the sum of the squared differences from the mean
        double sumOfSquares = prices.Select(val => (val - mean) * (val - mean)).Sum();

        // Calculate the variance
        double variance = sumOfSquares / (prices.Length - 1);

        // Calculate the standard deviation (volatility)
        double standardDeviation = Math.Sqrt(variance);

        return standardDeviation;
    }
}