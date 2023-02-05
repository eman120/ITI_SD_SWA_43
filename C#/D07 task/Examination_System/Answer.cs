using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Answer : IComparable
    {
        public string Body { get; set; }

        public int CompareTo(object? obj)
        {
            Answer answer = obj as Answer;
            //Answer answer = (Answer) obj;
            return Body.CompareTo(answer?.Body);
        }

        public override string ToString()
        {
            return $"{Body}";
        }

        public override bool Equals(object obj)
        {
            Answer answer = (Answer)obj;

            return answer?.Body.Equals(Body) ?? false;
        }
    }
}
