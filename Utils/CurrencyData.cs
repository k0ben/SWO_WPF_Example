namespace Utils
{
    public class CurrencyData : IComparable<CurrencyData>
    {
        // Properties
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Rate { get; set; }

        // Constructor
        public CurrencyData(string abb, string name, string country, double rate)
        {
            Abbreviation = abb;
            Name = name;
            Country = country;
            Rate = rate;
        }

        // Public Methods
        public int CompareTo(CurrencyData? other)
        {
            return Abbreviation?.CompareTo(other?.Abbreviation ?? string.Empty) ?? 1;
        }

        public override string ToString()
        {
            return Abbreviation;
        }
    }
}
