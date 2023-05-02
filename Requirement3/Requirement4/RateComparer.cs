using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    public class RateComparer:IComparer<Songs>
    {
        public int Compare(Songs x, Songs y)
        {
            return x.Rating.CompareTo(y.Rating);    
        }
    }
}
