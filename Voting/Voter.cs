using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Voter
    {
        Choice opinion;
        bool rebelious;
        public string address;
        public Voter(Choice opinion, bool rebelious, string address)
        {
            this.opinion = opinion;
            this.rebelious = rebelious;
            this.address = address;
        }

        public void Vote(Bulletin bulletin)
        {
            if(rebelious)
            {
                bulletin.spoiled = true;
            }
            else
            {
                bulletin.choice = opinion;
            }
        }
    }
}
