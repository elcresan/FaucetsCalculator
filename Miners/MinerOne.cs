namespace FaucetsCalculator.Miners
{
    internal class MinerOne : IMiner
    {
        /// <inheritdoc/>
        public int Cost { get => 30; }

        /// <inheritdoc/>
        public int Generates { get => 30; }
    }
}