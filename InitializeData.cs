namespace FaucetsCalculator {
    using System.Collections.Generic;

    internal static class InitializeData {

        public static List<Miner> GetMiners(){
            List<Miner> miners = new List<Miner>();

            miners.Add(new Miner(cost: 30, generates: 30));
            // TODO: Add the rest of miners;

            return miners;
        }
    }
}