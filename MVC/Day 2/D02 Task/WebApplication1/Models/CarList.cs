using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApplication1.Models
{
    public class CarList
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car(){Num = 1 , Color ="Red" , Model ="Ford" , Manfacture ="Ford Motor Co"},
            new Car(){Num = 2 , Color ="Blue" , Model ="Dodge" , Manfacture ="Stellantis"},
            new Car(){Num = 3 , Color ="Black" , Model ="Volvo" , Manfacture ="Zhejiang Geely Holding Group"},
            new Car(){Num = 4 , Color ="Purple" , Model ="BMW" , Manfacture ="BMW Group"},
            new Car(){Num = 5 , Color ="Aqua" , Model ="Jeep" , Manfacture ="Stellantis"},
            new Car(){Num = 6 , Color ="Pink" , Model ="Toyota" , Manfacture ="Toyota Motor Corp"},
        };

        //public static List<Car> Cars { get; set; } = new List<Car>()
        //{
        //    new Car(){Num = 1 , Color ="Red" , Model ="Ford" , Manfacture ="Ford Motor Co"},
        //    new Car(){Num = 2 , Color ="Blue" , Model ="Dodge" , Manfacture ="Stellantis"},
        //    new Car(){Num = 3 , Color ="Black" , Model ="Volvo" , Manfacture ="Zhejiang Geely Holding Group"},
        //    new Car(){Num = 4 , Color ="Purple" , Model ="BMW" , Manfacture ="BMW Group"},
        //    new Car(){Num = 5 , Color ="White" , Model ="Jeep" , Manfacture ="Stellantis"},
        //};
    }
}