namespace Utils
{
    public class CurrencyCalculator
    {
        // Properties
        public List<CurrencyData> Currencies { get; private set; }

        private static readonly Lazy<CurrencyCalculator> _lazy = new Lazy<CurrencyCalculator>(() => new CurrencyCalculator());
        public static CurrencyCalculator Instance => _lazy.Value;
        
        // Constructor
        private CurrencyCalculator()
        {
            Currencies = new List<CurrencyData>
            {
                new CurrencyData("USD", "Dollar", "USA", 1.13738),
                new CurrencyData("AUD", "Dollar", "Australia", 1.57875),
                new CurrencyData("GBP", "Pound", "GB", 0.904275),
                new CurrencyData("CNY", "Yuan", "China", 7.84050),
                new CurrencyData("INR", "Rupee", "India", 81.5578),
                new CurrencyData("JPY", "Yen", "Japan", 128.645),
                new CurrencyData("MXN", "Peso", "Mexico", 23.1019),
                new CurrencyData("EUR", "Euro", "Europe", 1.0)
            };
            Currencies.Sort();
        }

        // Public Methods
        public double Convert(double input, CurrencyData sourceCurrency, CurrencyData targetCurrency)
        {
            return input * (targetCurrency.Rate / sourceCurrency.Rate);
        }
    }
}
