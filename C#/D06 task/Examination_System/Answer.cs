using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Answer
    {
        public string Body { get; set; }

        public override string ToString()
        {
            return $"{Body}";
        }

        //public override bool Equals(object obj)
        //{
        //    Answers answers = (Answers)obj;

        //    return answers?.Body.Equals(Body) ?? false;
        //}
    }
}
