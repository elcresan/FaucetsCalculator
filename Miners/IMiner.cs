namespace FaucetsCalculator.Miners
{
    internal interface IMiner {
        /// <summary> The cost of buying the miner. </summary>
        int Cost { get; }
       
        /// <summary> The money that the miner generates each period. </summary>
         int Generates { get; }
    }
}