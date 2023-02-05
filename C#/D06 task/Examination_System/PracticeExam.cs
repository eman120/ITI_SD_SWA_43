using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(TimeSpan time, int numOfQuestion, subject subject) 
            : base(time, numOfQuestion, subject)
        {
        }

        public override void show()
        {
            throw new NotImplementedException();
        }
    }
}
