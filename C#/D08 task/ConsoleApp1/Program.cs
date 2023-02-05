namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isbn = "b1";
            string title = "life";
            string[] authors = {"Eman" , "Mohammed" };
            DateTime time = DateTime.Now;
            decimal price = 12;

            string R = string.Empty;
            Book book1 = new Book(isbn, title, authors, time, price);
            Book book2 = new Book(isbn, title, authors, time, price);

            List<Book> bList = new List<Book>();
            bList.Add(book1);
            //bList.Add(book2);

            #region a. User Defined Delegate Datatype
            Console.WriteLine("a. User Defined Delegate Datatype");
            DemoDelDT fptr;
            fptr = new DemoDelDT(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(bList, fptr);

            fptr = new DemoDelDT(BookFunctions.GetPrice);
            LibraryEngine.ProcessBooks(bList, fptr);

            fptr = new DemoDelDT(BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(bList, fptr);
            #endregion

            Console.WriteLine("==================================");
            #region b. BCL Delegates
            Console.WriteLine("b. BCL Delegates");
            Predicate<Book> fptr2;
            fptr2 = new Predicate<Book>(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(bList, fptr2);

            fptr2 = new Predicate<Book>(BookFunctions.GetPrice);
            LibraryEngine.ProcessBooks(bList, fptr2);

            fptr2 = new Predicate<Book>(BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(bList, fptr2);
            #endregion

            Console.WriteLine("==================================");
            #region c.Anonymous Method(GetISBN)
            Console.WriteLine("c.Anonymous Method(GetISBN)");
            Predicate<Book> fPtr3;
            //new Predicate<Book>(BookFunctions.GetTitle);
            fPtr3 = delegate (Book b) { return b.ISBN; };
            LibraryEngine.ProcessBooks(bList, fPtr3);
            #endregion

            Console.WriteLine("==================================");
            #region d.Lambda Expression(GetPublicationDate)
            Console.WriteLine("d.Lambda Expression(GetPublicationDate)");
            Predicate <Book> fPtr4 ;
            //new Predicate<Book>(BookFunctions.GetTitle)
            fPtr4 =  (Book b) => { return $"{b.PublicationDate}"; };
            LibraryEngine.ProcessBooks(bList, fPtr4);
            #endregion












            //R = fptr?.Invoke(book) ?? "invalid";

            //Console.WriteLine("GetTitle " + R);

            //R = fptr?.Invoke(book) ?? "invalid";

            //Console.WriteLine("GetPrice " + R);

            //R = fptr?.Invoke(book) ?? "invalid";
            //string[] Arr = R.Split(',');
            //for(int i = 0 ; i < authors.Length; i++) 
            //{           
            //    Console.WriteLine($"GetAuthor {i+1}) : {Arr[i]}");
            //}
        }
    }
}