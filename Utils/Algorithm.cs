namespace Utils
{
    public class Algorithm
    {
        // Delegates & Events
        public delegate void CalculationFinishedDelegate();
        public event CalculationFinishedDelegate? CalculationFinished;

        // Properties
        public int StartNumber { get; }
        public int Result { get; private set; }

        // Fields
        private readonly Random _random = new Random((int)DateTime.Now.Ticks);

        // Constructor
        public Algorithm(int startNumber)
        {
            StartNumber = startNumber;
        }

        // Public Methods
        public void DoCalculation()
        {
            Result = StartNumber;
            for (int i = 0; i < 100; ++i)
            {
                Result += _random.Next(1, 10);
                Thread.Sleep(10);
            }
            CalculationFinished?.Invoke();
        }
    }
}
