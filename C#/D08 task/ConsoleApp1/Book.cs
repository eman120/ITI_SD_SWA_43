using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate string DemoDelDT(Book book);
    public delegate string Predicate<T>(T book);


    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title,
        string[] _Authors, DateTime _PublicationDate,
        decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title; 
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            return
                $"ISBN ={ISBN}" +
                 $"Title = {Title} " +
                 $"Authors = {Authors}" +
                 $"PublicationDate = {PublicationDate} " +
                 $"Price = {Price}";
        }
    }
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B?.Title;
        }
        public static string GetAuthors(Book B)
        {
            string author = string.Empty;
            for(int i = 0; i< B?.Authors.Length; i++)
            {
                author += B?.Authors?[i];
                if(i < B?.Authors.Length-1)
                    author += ",";
            }
            return author;
        }
        public static string GetPrice(Book B)
        {
            return $"price = {B?.Price}";
        }
    }

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList
        ,/*Pointer To BookFunciton*/ Predicate<Book> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooks(List<Book> bList
        ,/*Pointer To BookFunciton*/ DemoDelDT fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
