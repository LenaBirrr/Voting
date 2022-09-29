using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    public class Commission
    {
        public string address = "test_address";

        public bool ValidateVoter(Voter voter)
        {
            return voter.address == this.address;
        }
        public Choice GetWinner(Box box)
        {
            return (Choice)Array.IndexOf(box.votes, box.votes.Max());
        }
    }


    public enum Choice
    {
        NONE,
        CANDIDAD_1,
        CANDIDAT_2,
        CANDIDAT_3,
        CANDIDAT_MULTIPAL,
    }

}
