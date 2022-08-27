using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selo
{
    public class Cards
    {

        public Random rand = new Random();


        public int GiveCards()
        {
            return rand.Next(2, 11);
        }


    }
}
