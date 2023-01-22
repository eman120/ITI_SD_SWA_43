using System.Drawing;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public enum Gender
    {
        M, F
    }

    [Flags]
    public enum privilege : byte
    {
        //CRUD
        //1000 => 8 
        //0100 => 4
        //0010 => 2
        //0001 => 0
        guest = 0x04, //R
        Developer = 0x0e, //CRU
        secretary = 0x0c, // CR
        DBA = 0x0d, // CRD
        officer = 0x0f //CRUD
    }

    public struct HireDate
    {

        int day;
        int month;
        int year;
        public HireDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            set { day = value; }
            get { return day; }
        }
        public int Month
        {
            set { month = value; }
            get { return month; }
        }
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        //public void setDay(int _day)
        //{
        //    this.day = _day;
        //} 

        //public int getDay()
        //{
        //    return this.day;
        //}

        //public void setMonth(int _month)
        //{
        //    this.month = _month;
        //}
        //public int getMonth()
        //{
        //    return this.month;
        //}

        //public void setYear(int _year)
        //{
        //    this.year = _year;
        //}
        //public int getYear()
        //{
        //    return this.year;
        //}

        public override string ToString()
        {
            return $"HireDate is : {this.day}/{this.month}/{this.year}";
        }
    }
    public struct Employee
    {
        int id;
        string name;
        privilege secutityLevel;
        int salary;
        HireDate date;
        Gender gender;
        public Employee(int ID, string name, privilege secutity_level, int salary, HireDate date, Gender gender)
        {
            this.id = ID;
            this.Name = name;
            this.secutityLevel = secutity_level;
            this.salary = salary;
            this.date = date;
            this.gender = gender;
        }

        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public privilege SecutityLevel
        {
            set { secutityLevel = value; }
            get { return secutityLevel; }
        }

        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public void Date(int d, int m, int y)
        {
            this.date.Day = d;
            this.date.Month = m;
            this.date.Year = y;
        }

        public string getDate
        {
            get
            {
                return $"{this.date.Day}/{this.date.Month}/{this.date.Year}";
            }
        }

        //get { return $"{this.date.Day} / {this.date.Month} / {this.date.Year}"; }
        public Gender Gender
        {
            set { gender = value; }
            get { return gender; }
        }


        //public int getID()
        //{
        //    return this.ID;
        //}

        //public void setID (int ID)
        //{
        //    this.ID = ID;
        //}
        //public privilege getSecutityLevel() {
        //    return this.secutityLevel;
        //}
        //public void setSecutityLevel(privilege secutityLevel)
        //{
        //    this.secutityLevel = secutityLevel;
        //}

        //public int getSalary()
        //{
        //    return this.salary;
        //}

        //public void setSalary(int salary)
        //{
        //    this.salary = salary;
        //}

        //public string getDate()
        //{
        //    return $"{this.date.getDay()} / {this.date.getMonth()} / {this.date.getYear()}";
        //}

        //public void setDate(int day, int month, int year)
        //{
        //    this.date.setDay(day);
        //    this.date.setMonth(month);
        //    this.date.setYear(year);
        //}

        //public Gender getGender()
        //{
        //    return this.gender;
        //}

        //public void setGender(Gender gender)
        //{
        //    this.gender = gender;
        //}

        public override string ToString()
        {
            return $"""
                Emp ID : {this.ID}
                Emp Name : {this.Name}
                Secutity Level : {this.secutityLevel}
                Salary : {this.salary:C}
                Gender : {this.gender}
                {this.date.ToString()}
                """;
        }
    }

    public class EmployeeSearch
    {
        Employee[] empArr;

        public EmployeeSearch (Employee[] empAr)
        {
            empArr = empAr;
        }

        public Employee this[int id]
        {
            set
            {
                if (id < empArr.Length)
                    empArr[id] = value;
            }
            get
            {
                for(int i = 0; i < empArr.Length ; i++)
                {
                    if (empArr[i].ID == id)
                    {
                        return empArr[i];
                    }
                }
                throw new IndexOutOfRangeException();
            }
        }

        public Employee this[string name]
        {
            get
            {
                for(int i=0; i<empArr.Length; i++)
                {
                    if (empArr[i].Name == name)
                    {
                        return empArr[i];
                    }
                }
                throw new IndexOutOfRangeException();
            }
        }

        public Employee this[int day , int month , int year ]
        {
            get
            {
                for (int i = 0; i < empArr.Length; i++)
                {
                    if (empArr[i].getDate == $"{day}/{month}/{year}")
                    {
                        return empArr[i];
                    }
                }
                throw new IndexOutOfRangeException();
            }
        }
    }
    
    //public class EmployeeSearch
    //{
    //    Employee[] empArr;
    //    int[] NationalIDs; 
    //    string[] empDate;
    //    string[] Names;
    //    List<string> empReturn;

    //    public EmployeeSearch(Employee[] empAr)
    //    {
    //        this.empArr = empAr;
    //        NationalIDs = new int[empAr.Length];
    //        Names = new string[empAr.Length];
    //        empDate = new string[empAr.Length];
    //        for (int i = 0; i < empArr.Length; i++)
    //        {
    //            NationalIDs[i] = empArr[i].ID;
    //        }
    //        for (int i = 0; i < empArr?.Length; i++)
    //        {
    //            Names[i] = empArr[i].Name;
    //        }
    //        for (int i = 0; i < empArr.Length; i++)
    //        {
    //            empDate[i] = empArr[i].getDate;
    //        }
    //    }
    //    //public EmployeeSearch(int[] id)
    //    //{
    //    //    this.NationalIDs = id;
    //    //}
    //    //public EmployeeSearch(HireDate[] empDate)
    //    //{
    //    //    this.empDate = empDate;
    //    //}
    //    //public EmployeeSearch(string[] Names)
    //    //{
    //    //    this.Names = Names;
    //    //}

    //    public string searchName(string nam)
    //    {
    //        for(int i=0; i <empArr.Length; i++)
    //        {
    //            if(nam == Names[i])
    //            {
    //                return empArr[i].ToString();
    //            }
    //        }
    //        return "Not Found";
    //    }

    //    public string searchID(int num)
    //    {
    //        for (int i = 0; i < empArr.Length; i++)
    //        {
    //            if (num == NationalIDs[i])
    //            {
    //                return empArr[i].ToString();
    //            }
    //        }
    //        return "Not Found";
    //    }

    //    public List<string> searchDate(string date)
    //    {
    //        empReturn = new List<string>();
    //        for (int i = 0; i < empDate.Length; i++)
    //        {
    //            if (date == empDate[i])
    //            {
    //                empReturn.Add(empArr[i].ToString());
    //            }
    //        }
    //        return empReturn;
    //    }
    //}


}