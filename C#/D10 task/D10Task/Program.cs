using static D10Task.ListGenerators;

using System;
using System.Diagnostics.Metrics;

namespace D10Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ProductList = ListGenerators.ProductList;
            var CustomerList = ListGenerators.CustomerList;
            string[] EnglishDictionary = File.ReadAllLines("dictionary_English.txt");

            #region LINQ - Restriction Operators
            Console.WriteLine("1- LINQ - Restriction Operators");
            Console.WriteLine("-------------1.Find all products that are out of stock.-------------");
            var Result = from P in ProductList
                         where P.UnitsInStock == 0
                         select P;
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("-------------2.Find all products that are in stock and cost more than 3.00 per unit.-------------");
            Result = from P in ProductList
                     where P.UnitsInStock > 0 && P.UnitPrice > 3
                     select P;
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            string[] numsArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine("-------------3.Returns digits whose name is shorter than their value.-------------");
            var Result02 = numsArr.Where((a, i) => a.Length < i);

            foreach (var item in Result02)
            {
                Console.WriteLine(item);
            }

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region LINQ - Element Operators
            Console.WriteLine("2- LINQ - Element Operators");

            Console.WriteLine("1.Get first Product out of Stock");
            var Result03 = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            Console.WriteLine(Result03);

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.");
            var Result0= ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            Console.WriteLine(Result0);

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine("3.Retrieve the second number greater than 5.");
            var Result04 = Arr.Where(a => a > 5).Skip(1).FirstOrDefault();
            Console.WriteLine(Result04);

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region LINQ - Set Operators

            Console.WriteLine("3- LINQ - Set Operators");

            Console.WriteLine("1.Find the unique Category names from Product List.");
            var Result05 = ProductList.Select(p => p.Category).Distinct();
            foreach (var item in Result05)
            {
                Console.WriteLine(item);
            }

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2.Produce a Sequence containing the unique first letter from both product and customer names.");
            var Result06 = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            foreach (var item in Result06)
            {
                Console.WriteLine(item);
            }

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("3.Create one sequence that contains the common first letter from both product and customer names.");
            var Result07 = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            foreach (var item in Result07)
            {
                Console.WriteLine(item);
            }

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.");
            var Result08 = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            foreach (var item in Result08)
            {
                Console.WriteLine(item);
            }

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("5.Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates");
            var Result09 = ProductList.Select(p => p.ProductName[^3..]).Concat(CustomerList.Select(c => c.CustomerName[^3..]));
            foreach (var item in Result09)
            {
                Console.WriteLine(item);
            }

            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region LINQ - Aggregate Operators
            Console.WriteLine("4- LINQ - Aggregate Operators");

            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine($"1.Uses Count to get the number of odd numbers in the array = {Arr1.Count(n => n % 2 == 1)}");
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2.Return a list of customers and how many orders each has.");
            var Obj1 = CustomerList.Select(c => new { c.CustomerName, OrdersCount = c.Orders.Length });
            foreach (var item in Obj1)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("3.Return a list of categories and how many products each has.");
            var Obj2 = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, ProductsCount = g.Count() });
            foreach (var item in Obj2)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            //int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine($"4.Get the total of the numbers in an array = {Arr1.Sum()}");
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"5.Get the total number of characters of all words in dictionary_english.txt = {EnglishDictionary.Sum(w => w.Length)}");
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("6.Get the total units in stock for each product category.");
            var Obj3 = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(u => u.UnitsInStock) });
            foreach (var item in Obj3)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"7.Get the length of the shortest word in dictionary_english.txt = {EnglishDictionary.Min(w => w.Length)}");
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("8.Get the cheapest price among each category's products");
            var Obj4 = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, CheapestPrice = g.Min(u => u.UnitPrice) });
            foreach (var item in Obj4)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("9.Get the products with the cheapest price in each category(Use Let)");
            var Obj5 = from p in ProductList
                       group p by p.Category into g
                       let minPrice = g.Min(u => u.UnitPrice)
                       from p in g
                       where p.UnitPrice == minPrice
                       select p;
            foreach (var item in Obj5)
            {
                Console.WriteLine($"{item.Category}: {item.ProductName} ({item.UnitPrice})");
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"10.Get the length of the longest word in dictionary_english.txt = {EnglishDictionary.Max(w => w.Length)}");
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("11.Get the most expensive price among each category's products.");
            var Obj6 = from p in ProductList
                       group p by p.Category into g
                       select new { Category = g.Key, MostExpensivePrice = g.Max(u => u.UnitPrice) };
            foreach (var item in Obj6)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("12.Get the products with the most expensive price in each category.");
            var Obj7 = from p in ProductList
                       group p by p.Category into g
                       let maxPrice = g.Max(u => u.UnitPrice)
                       from p in g
                       where p.UnitPrice == maxPrice
                       select p;
            foreach (var item in Obj7)
            {
                Console.WriteLine($"{item.Category}: {item.ProductName} ({item.UnitPrice})");
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"13.Get the average length of the words in dictionary_english.txt = {EnglishDictionary.Max(w => w.Length)}");
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("14.Get the average price of each category's products.");
            var Obj8 = from p in ProductList
                       group p by p.Category into g
                       select new { Category = g.Key, AveragePrice = g.Average(u => u.UnitPrice) };
            foreach (var item in Obj8)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region LINQ - Ordering Operators          
            Console.WriteLine("5- LINQ - Ordering Operators");

            Console.WriteLine("1.Sort a list of products by name");
            var productsList = ProductList.OrderBy(p => p.ProductName);
            foreach (var item in productsList)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            string[] wordsArr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine("2.Uses a custom comparer to do a case-insensitive sort of the words in an array.");
            var orderwordsArr = wordsArr.OrderBy(a => a, new CustomStringComparer());
            foreach (string word in orderwordsArr)
            {
                Console.WriteLine(word);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("3.Sort a list of products by units in stock from highest to lowest.");
            var productsList2 = ProductList.OrderByDescending(p => p.UnitsInStock);
            foreach (var item in productsList2)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            string[] Arr2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine("4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.");
            var _arr2 = Arr2.OrderBy(a => a.Length).ThenBy(a => a);
            foreach (string word in _arr2)
            {
                Console.WriteLine(word);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine("5.Sort first by word length and then by a case-insensitive sort of the words in an array.");
            var _words = words.OrderBy(a => a.Length).ThenBy(a => a, new CustomStringComparer());
            foreach (string word in _words)
            {
                Console.WriteLine(word);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("6.Sort a list of products, first by category, and then by unit price, from highest to lowest.");
            var productsList3 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            foreach (var item in productsList3)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine("7.Sort first by word length and then by a case-insensitive descending sort of the words in an array.");
            var _arr3 = Arr3.OrderBy(a => a.Length).ThenByDescending(a => a, new CustomStringComparer());
            foreach (string word in _arr3)
            {
                Console.WriteLine(word);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine("8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.");
            var _arr4 = Arr4.Where(a => a[^2] == 'i');
            foreach (string word in _arr4)
            {
                Console.WriteLine(word);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region LINQ - Partitioning Operators

            Console.WriteLine("6- LINQ - Partitioning Operators");

            Console.WriteLine("1.Get the first 3 orders from customers in Washington");
            var customerCity = CustomerList.Where(c => c.City == "Washington").Select(c => c.Orders).Take(3);
            foreach (var item in customerCity)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2.Get all but the first 2 orders from customers in Washington.");
            var customerCity2 = CustomerList.Where(c => c.City == "Washington")
                .Select(c => c.Orders).Skip(2);
            foreach (var item in customerCity2)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine("3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.");
            var numbersPositionTake = numbers.TakeWhile((n, i) => n >= i);
            foreach (var item in numbersPositionTake)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("4.Get the elements of the array starting from the first element divisible by 3.");
            var numDivisible3 = numbers.SkipWhile(n => n % 3 != 0);
            foreach (var item in numDivisible3)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("5.Get the elements of the array starting from the first element less than its position.");
            var numbersPositionSkip = numbers.SkipWhile((n, i) => n >= i);
            foreach (var item in numbersPositionSkip)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();
            #endregion



            #region LINQ - Projection Operators
            Console.WriteLine("7- LINQ - Projection Operators");

            string[] products = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            Console.WriteLine("1.Return a sequence of just the names of a list of products.");
            var productsSequence = products.Select(w => w);
            foreach (var item in productsSequence)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).");
            var productsSequence2 = products.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            foreach (var item in productsSequence2)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.");
            var productSequence = ProductList.Select(p => new { p.ProductID, p.ProductName, Price = p.UnitPrice });
            foreach (var item in productSequence)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            int[] indexedArr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine("4.Determine if the value of ints in an array match their position in the array.");
            var indexArr = indexedArr.Select((n, i) => n == i);
            foreach (var item in indexArr)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            Console.WriteLine("5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.");
            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select new { A = a, B = b };

            foreach (var pair in pairs)
            {
                Console.WriteLine(pair);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("6.Select all orders where the order total is less than 500.00.",
                    CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500));
            var ordersTotals = from c in CustomerList
                       from o in c.Orders
                       where o.Total < 500
                       select new { c.CustomerID, o.OrderID, o.Total };

            foreach (var item in ordersTotals)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("7.Select all orders where the order was made in 1998 or later.");
            var dateOrders = from c in CustomerList
                       from o in c.Orders
                       where o.OrderDate.Year >= 1998
                       select new { c.CustomerID, o.OrderID, o.OrderDate };

            foreach (var item in dateOrders)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();
            #endregion



            #region LINQ - Quantifiers
            Console.WriteLine("8- LINQ - Quantifiers");

            Console.WriteLine("1.Determine if any of the words in dictionary_english.txt contain the substring 'ei'.");
            bool contain = EnglishDictionary.Any(w => w.Contains("ei"));
            Console.WriteLine(contain);

            var englishWord = from d in EnglishDictionary
                        where d.Contains("ei")
                        select d;
            Console.WriteLine("The words in dictionary_english.txt contain the substring 'ei' are :");
            foreach (var item in englishWord)
            {
                Console.WriteLine(item);
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2.Return a grouped list of products only for categories that have at least one product that is out of stock.");
            var productNotInStock = ProductList.Where(p => ProductList.Where(c => p.Category == c.Category)
                                                         .Any(c => c.UnitsInStock == 0))
                                   .GroupBy(p => p.Category);
            foreach (var group in productNotInStock)
            {
                Console.WriteLine("Category: " + group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine("\t" + product.ProductName + " " + product.UnitsInStock);
                }
            }
            Console.ReadLine();
            Console.Clear();

            ///Another Solution
            //var groupedProducts = from p in ProductList
            //              where p.UnitsInStock == 0
            //              group p by p.Category into g
            //              select g;
            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine("Category: " + group.Key);
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine("\t" + product.ProductName + " " + product.UnitsInStock);
            //    }
            //}
            ////press any button to clear the console and show the next one
            //Console.ReadLine();
            //Console.Clear();

            Console.WriteLine("3.Return a grouped list of products only for categories that have all of their products in stock.");
            var productInStock = ProductList.Where(p => ProductList.Where(c => p.Category == c.Category)
                                                          .All(c => c.UnitsInStock != 0))
                                   .GroupBy(p => p.Category);
            foreach (var group in productInStock)
            {
                Console.WriteLine("Category: " + group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine("\t" + product.ProductName + " " + product.UnitsInStock);
                }
            }
            Console.ReadLine();
            Console.Clear();

            ///Another Solution
            //var groupedProducts = from p in ProductList
            //              where p.UnitsInStock != 0
            //              group p by p.Category into g
            //              select g;
            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine("Category: " + group.Key);
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine("\t" + product.ProductName + " " + product.UnitsInStock);
            //    }
            //}
            ////press any button to clear the console and show the next one
            //Console.ReadLine();
            //Console.Clear();
            #endregion

            #region LINQ - Grouping Operators
            Console.WriteLine("9- LINQ - Grouping Operators");

            List<int> nums = Enumerable.Range(0, 14).ToList();
            Console.WriteLine("1.Use group by to partition a list of numbers by their remainder when divided by 5.");
            var groupedNumbers = from number in nums
                                 group number by number % 5 into g
                                 select g;
            foreach (var group in groupedNumbers)
            {
                Console.WriteLine("Remainder: " + group.Key);
                foreach (var number in group)
                {
                    Console.WriteLine("\t" + number);
                }
            }
            //press any button to clear the console and show the next one
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2.Uses group by to partition a list of words by their first letter.");
            var groupedWords = EnglishDictionary.GroupBy(w => w[0]); 

            foreach (var group in groupedWords)
            {
                Console.WriteLine("First letter: " + group.Key);
                //just print 10 words for each letter
                for (int i =1; i <10; i++)
                {
                    Console.WriteLine("\t" + group.ToList()[i]);
                }
            }
            Console.ReadLine();
            Console.Clear();

            ////Another Solution
            //var groupedWords = from word in EnglishDictionary group word by word[0] into g select g;
            //foreach (var group in groupedWords)
            //{
            //    Console.WriteLine("first letter: " + group.Key);
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine("\t" + word);
            //    }
            //}

            string[] wordArr = { "from", "salt", "earn", "last", "near", "form" };
            Console.WriteLine("3.Consider this Array as an Input."+
                "\nUse Group By with a custom comparer that matches words that are consists of the same Characters Together");
            var anagramCompared = wordArr.GroupBy(w => w , new AnagramEqualityComparer());
            foreach (var group in anagramCompared)
            {
                Console.WriteLine("Original Word : " + group.Key);
                foreach (var _word in group)
                {
                    Console.WriteLine("\t" + _word);
                }
            }

            #endregion
        }

    }
}