using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Card
    {
        public Card(string face, string suits)
        {
            Face = face;
            Suit = suits;
        }

        public string Face { get; private set; }
        public string Suit { get; private set; }


        public override string ToString()
        {
            if (Suit == "S")
            {
                Suit = "\u2660";
            }
            if (Suit == "H")
            {
                Suit = "\u2665";
            }
            if (Suit == "D")
            {
                Suit = "\u2666";
            }
            if (Suit == "C")
            {
                Suit = "\u2663";
            }
            return $"[{Face}{Suit}]";
        }
    }
}
