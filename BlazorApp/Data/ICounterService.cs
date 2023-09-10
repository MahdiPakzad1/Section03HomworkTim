namespace BlazorApp.Data
{
    public interface ICounterService
    {
        int CounterValue { get; }

        void IncrementCounter();
    }
}