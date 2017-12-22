namespace FaucetsCalculator {
    
    using System.Collections.Generic;
    using FaucetsCalculator.Miners;
    
    internal class Farm {
        private List<IMiner> miners;

        private int period;

        public Farm()
        {            
            this.miners = new List<IMiner>();
            this.period = 0;
        }

        public void AddMiner (IMiner miner){
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