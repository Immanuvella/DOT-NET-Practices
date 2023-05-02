using Requirement3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    internal class PopularityComparer:IComparer<Songs>
    {
        public int Compare(Songs x, Songs y)
        {
            return y.NumberofDownloads.CompareTo(x.NumberofDownloads);
        }
    }
}
