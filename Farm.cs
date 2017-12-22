namespace FaucetsCalculator {
    
    using System.Collections.Generic;
    using FaucetsCalculator.Miners;
    
    internal class Farm {
        private List<Miner> miners;

        private int period;

        public Farm()
        {            
            this.miners = new List<Miner>();
            this.period = 0;
        }

        public void AddMiner (Miner miner){
            this.miners.Add(miner);
        }

        public void PassPeriod(int numberOfPeriods = 1)
        {
            if(numberOfPeriods <= 0)
            {
                return;
            }

            this.period += numberOfPeriods;

            // TODO: Create a wallet and update its amounts based on miners.
        }
    }
}