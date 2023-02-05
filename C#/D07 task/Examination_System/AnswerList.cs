using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class AnswerList : List<Answer>
    {
        public override bool Equals(object obj)
        {
            AnswerList answer = obj as AnswerList;
            for(int i = 0 ; i < answer?.Count; i++)
            {
                if (!answer[i].Body.Equals(this[i].Body))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
