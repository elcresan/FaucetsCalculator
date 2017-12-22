namespace FaucetsCalculator.Miners
{
    internal interface IMiner {
        int Cost { get; }
        int Generates { get; }
    }
}