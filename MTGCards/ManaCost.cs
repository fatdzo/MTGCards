using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    public class ManaCost
    {
        public int CMC {

            get {
                if (ColorCost != null) {
                    var res = 0;

                    foreach (var cst in ColorCost) {
                        res += cst.Amount;
                    }

                    return res;
                }
                return 0;
            }
        }
        //Determines if the mana cost includes tapping of the card
        public bool TapManaCost = false;
        //Determines if the mana cost includes untapping of the card
        public bool UntapManaCost = false;

        public List<ColorCost> ColorCost;
    }
}
