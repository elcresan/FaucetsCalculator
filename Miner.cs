namespace FaucetsCalculator
{
    internal class Miner {

        public Miner(int cost, int generates)
        {
            this.Cost = cost;
            this.Generates = generates;
        }

        /// <summary> The cost of buying the miner. </summary>
        int Cost { get; set; }
       
        /// <summary> The money that the miner generates each period. </summary>
         int Generates { get; set; }
    }
}