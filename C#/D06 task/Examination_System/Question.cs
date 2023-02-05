using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Question
    {
        string Body;
        int Marks;
        string Header;
        Answer[] QuestAnswer;

        public int Marks1 { get => Marks; set => Marks = value; }
        public string Header1 { get => Header; set => Header = value; }
        public string Body1 { get => Body; set => Body = value; }
        internal Answer[] QuestAnswer1 { get => QuestAnswer; set => QuestAnswer = value; }

        public Question(string _Body, int _Marks, string _Header , Answer[] _QuestAnswer)
        {
            Body1 = _Body;
            Marks1 = _Marks;
            Header1 = _Header;
            QuestAnswer1 = _QuestAnswer;
        }

        public override string ToString()
        {
            return $"-Header:{Header}\n-Body:{Body}\n-Marks:{Marks}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Question question &&
                Body == question.Body1 &&
                Marks == question.Marks1 &&
                Header == question.Header1;
                //All_Answer.Equals(question.All_Answer);
        }
    }
}
