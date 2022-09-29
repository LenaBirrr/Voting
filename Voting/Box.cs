using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Box
    {

        public int[] votes = new int[3];

        public bool ValidateBulletin(Bulletin bulletin)
        {
            return !bulletin.spoiled;
        }
        public void CountBulletin(Bulletin bulletin)
        {
            if(ValidateBulletin(bulletin))
            {
                votes[((int)bulletin.choice)]++;
            }
        }
    }
}
