namespace StockAnalyzer;

public static class StockAnalysis
{
    public class VolatilityCalculator
    {
        public static double CalculateVolatility(double[] prices)
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

        public static double CalculateCoefficientOfVariation(double[] prices)
        {
            // Calculate the standard deviation (volatility)
            double standardDeviation = CalculateVolatility(prices);

            // Calculate the mean of the prices
            double mean = prices.Average();

            // Calculate the coefficient of variation (CV)
            double coefficientOfVariation = standardDeviation / mean;

            return coefficientOfVariation;
        }
    }
}

public class StockData
{
    public DateTime Date { get; set; }
    public string Symbol { get; set; }
    public decimal Price { get; set; }
}
