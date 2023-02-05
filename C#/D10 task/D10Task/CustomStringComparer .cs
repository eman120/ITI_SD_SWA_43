using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10Task
{
    class CustomStringComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            //if (x == null && y == null) return 0;
            //if(x ==null) return -1;
            //if(y == null) return 1;

            //int min  = Math.Min(x.Length, y.Length);    
            //for(int i =0; i < min; i++)
            //{
            //    if (x[i] == y[i] ) continue;
            //    if (x[i].ToString().ToLower()[0] > y[i].ToString().ToLower()[0]) return 1;

            //    return -1;
            //}
            //return 0;

            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            
        }
    }
}
