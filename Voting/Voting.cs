using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Voting
{
   
    public class Voting
    {
              
        public Choice Run()
        {
            Voter voter = new Voter(Choice.CANDIDAD_1, false, "test_address");
            Box box = new Box();
            Commission commission = new Commission();
            Bulletin bulletin = new Bulletin();
            voter.Vote(bulletin);
            box.CountBulletin(bulletin);
            return commission.GetWinner(box);


        }

    }
}
