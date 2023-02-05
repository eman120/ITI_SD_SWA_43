using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class FinalExam<T> : Exam<T>
        where T : Question
    {
        public FinalExam(TimeSpan time, int numOfQuestion
            , subject subject , Dictionary<T , AnswerList> dict)
            : base(time, numOfQuestion, subject , dict)
        {
        }

        public override void show()
        {
            int countQ = 1;
            int countA = 1;
            int totalMarks = 0;
            AnswerList answers = new AnswerList();
            int ExamMarks = 0;

            foreach (var item in Question_Answer)
            {
                Console.WriteLine($"{countQ}){item.Key.Body}");
                ExamMarks += item.Key.Marks;

                foreach (Answer a in item.Key?.All_Answer)
                {
                    Console.WriteLine($"{countA}-{a.ToString()}");
                    countA++;
                }
                countA = 1;
                if (item.Key is TrueORFalse || item.Key is Choose_One)
                {
                    int answ = -1;
                    Answer answer = new Answer();
                    Console.WriteLine("Enter Your Answer");
                    if (int.TryParse(Console.ReadLine(), out answ) 
                        && answ > -1 && answ <= item.Key.All_Answer.Count)
                    {
                        answer.Body = item.Key.All_Answer[answ - 1].Body;
                    }
                    answers.Add(answer);
                }
                else if (item.Key is Choose_All)
                {
                    Answer answer;
                    int num;
                    do
                    {
                        Console.WriteLine("Enter Number of your answers");
                    } while (!int.TryParse(Console.ReadLine(), out num));

                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine($"Enter Your Choice {i + 1}");
                        answer = new Answer();
                        answer.Body = Console.ReadLine();
                        answers.Add(answer);
                    }
                }
                if (correctAnswers(answers, item.Value))
                {
                    totalMarks += item.Key.Marks;
                }
                countQ++;
                answers = new AnswerList();
            }
            Console.WriteLine($"Total Grade : {totalMarks} from {ExamMarks}");
            Console.WriteLine("===========================");
        }

        //public bool correctAnswers(AnswerList answers , AnswerList rightAnswers)
        //{
        //    answers.Sort();
        //    rightAnswers.Sort();

        //    if(answers.Count == rightAnswers.Count)
        //    {
        //        for(int x = 0; x < rightAnswers.Count; x++)
        //        {
        //            if (!answers[x]?.Body?.ToLower().Equals(rightAnswers[x]?.Body?.ToLower()) ?? true)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}
