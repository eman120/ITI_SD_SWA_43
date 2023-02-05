using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Choose_All : Question
    {
        public Choose_All(string _Body, int _Marks, string _Header, AnswerList answers)
            : base(_Body, _Marks, _Header, answers)
        {
        }
    }
}
