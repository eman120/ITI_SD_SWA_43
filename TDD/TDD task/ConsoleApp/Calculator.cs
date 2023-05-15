using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Calculator
    {
        #region An empty string
        //public static int Add(string numbers)
        //{
        //    return 0;
        //}
        #endregion

        #region 1 Number string
        //public static int Add(string numbers)
        //{
        //    if (numbers.Length == 1)
        //    {
        //        return int.Parse(numbers);
        //    }
        //    return 0;
        //}
        #endregion

        #region 2 Number string
        //public static int Add(string numbers)
        //{
        //    if (numbers.Length == 0)
        //    {
        //        return 0;
        //    }
        //    if (numbers.Length == 1)
        //    {
        //        return int.Parse(numbers);
        //    }
        //    var numArr = numbers.ToCharArray().ToList();
        //    return int.Parse(numArr[0].ToString()) + int.Parse(numArr[1].ToString());
        //}
        #endregion

        #region Numbers string
        //public static int Add(string numbers)
        //{
        //    if (numbers.Length == 0)
        //    {
        //        return 0;
        //    }
        //    //var numArr = numbers.ToCharArray().ToList();
        //    //int sum = numArr.Sum(r => int.Parse(r.ToString()));
        //    var numArr = numbers.Split(',');
        //    return numArr.Sum(r => int.Parse(r));
        //}
        #endregion

        #region new line Numbers string
        //public static int Add(string numbers)
        //{
        //    if (numbers.Length == 0)
        //    {
        //        return 0;
        //    }

        //    var numArr = numbers.Split(',','\n');
        //    return numArr.Sum(r => int.Parse(r));
        //}
        #endregion

        #region a negative number - Numbers string
        public static int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            var numArr = numbers.Split(',', '\n');
            var negativeNumbers = numArr.Where(n => n[0] == '-');
            var negativeString = String.Join(",", negativeNumbers);

            if (negativeString != "")
                throw new System.ArgumentException(
                    $"The numbers string had the following negative value/s: {negativeString}"
                );

            return numArr.Sum(r => int.Parse(r));
        }
        #endregion
    }
}
