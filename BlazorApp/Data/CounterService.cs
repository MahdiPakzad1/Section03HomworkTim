namespace BlazorApp.Data
{
    public class CounterService : ICounterService
    {
        private readonly ILogger<CounterService> log;

        public CounterService(ILogger<CounterService> log)
        {
            this.log = log;
        }

        public int CounterValue { get; private set; }

        public void IncrementCounter()
        {
            CounterValue += 1;
            log.LogInformation("The counter was incremented to {CounterValue}", CounterValue);
        }

    }
}
