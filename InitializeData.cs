namespace FaucetsCalculator {
    using System.Collections.Generic;

    internal static class InitializeData {

        public static List<Miner> GetMiners(){
            List<Miner> miners = new List<Miner>();

            miners.Add(new Miner(cost: 30, generates: 30, name: "First"));
            miners.Add(new Miner(cost: 200, generates: 220, name: "Second"));
            miners.Add(new Miner(cost: 1500, generates: 1800, name: "Third"));
            miners.Add(new Miner(cost: 5000, generates: 7000, name: "Fourth"));
            miners.Add(new Miner(cost: 25000, generates: 37000, name: "Fifth"));
            miners.Add(new Miner(cost: 100000, generates: 150000, name: "Sixth"));
            miners.Add(new Miner(cost: 250000, generates: 400000, name: "Seventh"));
            miners.Add(new Miner(cost: 500000, generates: 850000, name: "Eighth"));

            return miners;
        }
    }
}
