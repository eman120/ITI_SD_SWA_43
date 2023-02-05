using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }



        public Duration(int _Hours, int _Minutes, int _Seconds)
        {
            Seconds = _Seconds;
            Hours = _Hours;
            Minutes = _Minutes;
        }

        public Duration(int x)
        {
            if (x < 3600)
            {
                Hours = 0;
                Minutes = x % 3600 / 60;
                Seconds = (x - (0 + x % 3600 / 60) * 60);
            }

            else if (x == 3600)
                Hours = x / 3600;

            else if (x > 3600)
            {
                Hours = x / 3600;
                Minutes = x % 3600 / 60;
                Seconds = (x - ((x / 3600) * 3600 + (x % 3600 / 60) * 60));
            }
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != typeof(Duration))
                return false;

            if (obj is Duration)
            {
                return
                    (
                    Hours == ((Duration)obj).Hours
                    &&
                    Minutes == ((Duration)obj).Minutes
                    &&
                    Seconds == ((Duration)obj).Seconds
                    );
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }

        #region operator overloading

        public static Duration operator +(Duration left, Duration right)
        {
            return (
                new Duration(left.Hours + right.Hours, left.Minutes + right.Minutes
            , left.Seconds + right.Seconds)
                   );
        }

        public static Duration operator +(Duration left, int num)
        {
            int hrs = (2 * (num - 3600) / 3600);
            int mnt = ((num - 3600) - 3600) / 60;
            int sec = (hrs - mnt) / 60;
            return (
                new Duration(left.Hours + hrs, left.Minutes + mnt
            , left.Seconds + sec)
                   );
        }

        public static Duration operator +(int num, Duration left)
        {
            //int hrs = Convert.ToInt32(2 * (num - 3600) / 3600);
            //int mnt = ((num - 3600) - 3600) / 60;
            //int sec = (hrs - mnt) / 60;

            //return (
            //    new Duration(left.Hours + hrs, left.Minutes + mnt
            //, left.Seconds + sec)
            //       );
            return new Duration(num) + left;

        }

        //postfix and prefix
        public static Duration operator ++(Duration left)
        {
            return
                (
                new Duration(left.Hours, left.Minutes + 1, left.Seconds)
                );
        }

        public static Duration operator --(Duration left)
        {
            Duration D = new Duration(left.Hours, left.Minutes - 1, left.Seconds);
            
            if(D.Minutes==  -1)
            {
                D.Hours--;
                D.Minutes = 59;
            }
            return D;
             
        }


        public static Duration operator -(Duration left)
        {
            return
                (
                new Duration(-left.Hours, -left.Minutes, -left.Seconds)
                );
        }

        public static bool operator >=(Duration left, Duration right)
        {
            if (left == null || right == null) return false;

            return
                (
                ((left?.Hours) >= (right?.Hours)) && (left?.Minutes >= right?.Minutes) && (left?.Seconds >= right?.Seconds)
                );
        }
        public static bool operator <=(Duration left, Duration right)
        {

            if (left == null || right == null) return false;

            return
                (
                ((left?.Hours) <= (right?.Hours)) && (left?.Minutes <= right?.Minutes) && (left?.Seconds <= right?.Seconds)
                );
        }

        public static explicit operator DateTime(Duration left)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, left.Hours, left.Minutes, left.Seconds);
        }

        public static implicit operator bool(Duration left)
        {
            if (left?.Seconds == null && left?.Hours == null && left?.Hours == null)
                return false;

            return true;
        }

        #endregion
    }
}
