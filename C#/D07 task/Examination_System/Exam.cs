using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    abstract class Exam<T>
          where T : Question
    {
        public TimeSpan Time { set; get; }
        public int NumOfQuestion { set; get; }
        internal subject Subject { get ; set; }

        //private subject subject;
        public Dictionary<T, AnswerList> Question_Answer { get; set; } 
            = new Dictionary<T, AnswerList>();

        public Exam(TimeSpan time,
            int numOfQuestion,
            subject subject , Dictionary<T, AnswerList> dict)
        {
            Time = time;
            NumOfQuestion = numOfQuestion;
            Subject = subject;
            Question_Answer = dict;
        }
        public abstract void show();

        public bool correctAnswers(AnswerList answers, AnswerList rightAnswers)
        {
            Console.WriteLine("-----------------------");
            answers.Sort();
            rightAnswers.Sort();

            if (answers.Count == rightAnswers.Count)
            {
                for (int x = 0; x < answers.Count; x++)
                {
                    if (!answers[x]?.Body?.ToLower().Equals(rightAnswers[x]?.Body?.ToLower()) ?? true)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
