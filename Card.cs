using System;
using GoFish;
using System.Collections.Generic;
using System.Text;

namespace GoFish
{
    public class Card
    {

        public string Suite { get; set; } // trying different ways to get and set 
        public string Rank { get; set; }

        public Card(string suite, string rank)
        {
            Suite = suite;
            Rank = rank;
        }

        public string ShowMe()
        {
            return Suite + Rank;

        }

        public override string ToString()  // is a part of the Print Cards method for lists.
        {
            return Suite + Rank;

        }


    }
}
