namespace FaucetsCalculator
{
    internal class Miner {

        public Miner(int cost, int generates, string name)
        {
            this.Cost = cost;
            this.Generates = generates;
            this.Name = name;
        }

        /// <summary> The cost of buying the miner. </summary>
        int Cost { get; set; }

        /// <summary> The money that the miner generates each period. </summary>
        int Generates { get; set; }

        /// <summary> The name of the miner. </summary>
        string Name { get; set; }
    }
}
