using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Question
    {
        public string Body { get; }
        public int Marks { get; }
        public string Header { get; }
        public AnswerList All_Answer { get; }

        public Question(string _Body, int _Marks, string _Header,
            AnswerList answers)
        {
            Body = _Body;
            Marks = _Marks;
            Header = _Header;
            All_Answer = answers;

        }
        public override bool Equals(object obj)
        {
            return obj is Question question &&
                Body == question.Body &&
                Marks == question.Marks &&
                Header == question.Header &&
                All_Answer.Equals(question.All_Answer);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Body.Length, All_Answer.Count, Marks);
        }

        public override string ToString()
        {
            return $"-Header:{Header}\n-Body:{Body}\n-Marks:{Marks}\n";
        }

    }
}
