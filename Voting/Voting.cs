using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Voting
    {
        public enum Choice
        {
            NONE,
            CANDIDAD_1,
            CANDIDAT_2,
            CANDIDAT_3,
            CANDIDAT_MULTIPAL,
        }
        public string address = "test_address";
        public int[] votes = new int[3];
        public void ValidateChoice(ref Choice choice, bool spoiled)
        {
            if(choice==Choice.NONE||choice==Choice.CANDIDAT_MULTIPAL)
            {
                spoiled = true;
            }
            else
            {
                votes[((int)choice)]++;
            }
        }

        public bool ValidateVoter(string address)
        {
            return this.address == address;
        }
        public Choice GetWinner()
        {
            return (Choice)Array.IndexOf(votes,votes.Max());
        }

    }
}
