using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    abstract class Exam
    {
        public TimeSpan Time { set; get; }
        public int NumOfQuestion { set; get; }
        internal subject Subject { get => subject; set => subject = value; }

        private subject subject;
        public abstract void show();

        public Exam(TimeSpan time,
            int numOfQuestion,
            subject subject)
        {
            Time = time;
            NumOfQuestion = numOfQuestion;
            Subject = subject;
        }

    }
}
