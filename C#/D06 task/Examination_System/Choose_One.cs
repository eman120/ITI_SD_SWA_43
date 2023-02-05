using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Choose_One : Question
    {
        public Choose_One(string _Body, int _Marks, string _Header)
        : base(_Body, _Marks, _Header)
        { }
    }
}
