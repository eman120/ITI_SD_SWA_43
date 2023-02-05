namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            TimeSpan time1 = new TimeSpan();
            int numOfQuestion = 5;
            subject subject1 = new subject();
            subject1.Subject = "HTML";

            AnswerList answers1 = new AnswerList(); //right answer = a
            answers1.Add(new Answer() { Body = "Hyper Text Markup Language" });
            answers1.Add(new Answer() { Body = "Holistick Technical Method Library" });
            answers1.Add(new Answer() { Body = "Hyper Tax Makes Line" });
            answers1.Add(new Answer() { Body = "None of the above" });
            Question q1 = new Choose_One("What does the abbreviation HTML stand for?", 10, "choose", answers1);
            
            AnswerList answersR1 = new AnswerList();
            answersR1.Add(new Answer() { Body = "Hyper Text Markup Language" });


            AnswerList answers2 = new AnswerList(); //right answer = c
            answers2.Add(new Answer() { Body = "Web browser" });
            answers2.Add(new Answer() { Body = "text editor" });
            answers2.Add(new Answer() { Body = "Both [A] and [B]" });
            answers2.Add(new Answer() { Body = "None of the above" });
            Question q2 = new Choose_One("To create HTML page, you need _____", 10, "choose", answers2);
            
            AnswerList answersR2 = new AnswerList();
            answersR2.Add(new Answer() { Body = "Both [A] and [B]" });


            AnswerList answers3 = new AnswerList(); //right answer = b
            answers3.Add(new Answer() { Body = "True" });
            answers3.Add(new Answer() { Body = "False" });
            Question q3 = new TrueORFalse("Are HTML tags case sensitive?", 10, "trueOrfale", answers3);
            AnswerList answersR3 = new AnswerList();
            answersR3.Add(new Answer() { Body = "False" });

            AnswerList answers4 = new AnswerList(); //right answer = a
            answers4.Add(new Answer() { Body = "True" });
            answers4.Add(new Answer() { Body = "False" });
            Question q4 = new TrueORFalse("Inline elements are normally displayed without starting a new line.", 10, "trueOrfale", answers4);
            AnswerList answersR4 = new AnswerList();
            answersR4.Add(new Answer() { Body = "True" });

            AnswerList answers5 = new AnswerList(); //right answer = a , b , c
            answers5.Add(new Answer() { Body = "save it with binary file" });
            answers5.Add(new Answer() { Body = "save it with WMF file" });
            answers5.Add(new Answer() { Body = "save it with ASCII text file" });
            answers5.Add(new Answer() { Body = "None of the above" });
            Question q5 = new Choose_All("If you create an HTML page in word processor,____.", 10, "Choose_All", answers5);
            AnswerList answersR5 = new AnswerList();
            answersR5.Add(new Answer() { Body = "save it with binary file" });
            answersR5.Add(new Answer() { Body = "save it with WMF file" });
            answersR5.Add(new Answer() { Body = "save it with ASCII text file" });


            Dictionary<Question, AnswerList> dict =
                new Dictionary<Question, AnswerList>();
            dict.Add(q1, answersR1);
            dict.Add(q2, answersR2);
            dict.Add(q3, answersR3);
            dict.Add(q4, answersR4);
            dict.Add(q5, answersR5);


            Console.WriteLine("There are two type of Exam :" +
                " Practice Exam and Final Exam");

            do
            {
                Console.WriteLine("please Enter 1 to practice or  2 to  Final");
            } while (!Int32.TryParse(Console.ReadLine(), out x) && (x == 1 || x == 2));

            Console.WriteLine("=============================================================");
            if (x == 1)
            {
                Console.WriteLine($"Practice Exam for subject {subject1.Subject}");
                Console.WriteLine("********************************");
                PracticeExam<Question> practice = 
                    new PracticeExam<Question>(time1 , numOfQuestion , subject1 , dict);
                practice.show();
            }
            else if (x == 2)
            {
                Console.WriteLine($"Final Exam for subject {subject1.Subject}");
                Console.WriteLine("*****************************");
                FinalExam<Question> final = 
                    new FinalExam<Question>(time1 ,numOfQuestion , subject1, dict); 
                final.show();
            }
        }
    }
}