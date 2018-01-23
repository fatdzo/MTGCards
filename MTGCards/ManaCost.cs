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
        public List<ColorCost> ColorCost;
    }
}
