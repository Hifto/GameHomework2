using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class BlackJackHand : Hand
    {
        public override int CompareTo(Hand OtherHandObject)
        {
            if (this.EvaluateHand() == OtherHandObject.EvaluateHand())
            {
                return 0;
            }
            else if (this.EvaluateHand() < OtherHandObject.EvaluateHand())
            {
                return -1;
            }
            else if (this.EvaluateHand() > OtherHandObject.EvaluateHand())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override int EvaluateHand()
        {
            throw new NotImplementedException();
        }
    }
}
