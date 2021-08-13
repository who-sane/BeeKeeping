using System.Collections.Generic;
using Beez.classLib;
namespace Beez.classLib
{
    public class Hive
    {
        
        public int maxAmount { get; set; }
        public List<Bee> Bees { get; set; }

        public Hive(int maxAmount)
         {
            this.maxAmount = maxAmount;
            this.Bees = new List<Bee>();
         }

        
        /*
          Collect Honey (days: int)
          Amount: float = days * bee Size * 0.2
        */
        public float collecthoney(int days){
            float amount = 0;
            float honey = 0;
            for (int i = 0; i < this.Bees.Count; i++)
            {
            amount = amount + this.Bees[i].Size; 
            }
            honey = (amount*days)*0.2f;
            return honey;
         }

    }
}