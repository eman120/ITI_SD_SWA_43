namespace ConsoleApp1
{
    public enum Gender
    {
        M , F
    }

    [Flags]
    public enum privilege:byte
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
        //public int Day{
        //    set{ day = value; }
        //    get{ return day; }
        //}
        public void setDay(int _day)
        {
            this.day = _day;
        } 

        public int getDay()
        {
            return this.day;
        }

        public void setMonth(int _month)
        {
            this.month = _month;
        }
        public int getMonth()
        {
            return this.month;
        }

        public void setYear(int _year)
        {
            this.year = _year;
        }
        public int getYear()
        {
            return this.year;
        }

        public override string ToString()
        {
            return $"HireDate is : {this.day}/{this.month}/{this.year}";
        }
    }
    public struct Employee
    {
        int ID;
        privilege secutityLevel;
        int salary;
        HireDate date;
        Gender gender;
        public Employee(int ID , privilege secutity_level , int salary , HireDate date , Gender gender)
        {
            this.ID = ID;
            this.secutityLevel = secutity_level;
            this.salary = salary;
            this.date = date;   
            this.gender = gender;
        }

        public int getID()
        {
            return this.ID;
        }

        public void setID (int ID)
        {
            this.ID = ID;
        }
        public privilege getSecutityLevel() {
            return this.secutityLevel;
        }
        public void setSecutityLevel(privilege secutityLevel)
        {
            this.secutityLevel = secutityLevel;
        }

        public int getSalary()
        {
            return this.salary;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public string getDate()
        {
            return $"{this.date.getDay()} / {this.date.getMonth()} / {this.date.getYear()}";
        }

        public void setDate(int day, int month, int year)
        {
            this.date.setDay(day);
            this.date.setMonth(month);
            this.date.setYear(year);
        }

        public Gender getGender()
        {
            return this.gender;
        }

        public void setGender(Gender gender)
        {
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"""
                Emp ID : {this.ID}
                Secutity Level : {this.secutityLevel}
                Salary : {this.salary:C}
                Gender : {this.gender}
                {this.date.ToString()}
                """
                
                ;
        }
    }



}