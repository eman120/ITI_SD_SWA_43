namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            { BirthDate = new DateTime(1970, 9, 22), VacationStock = 21, EmployeeID = 1 };

            Employee employee2 = new Employee()
            { BirthDate = new DateTime(1995, 10, 22), VacationStock = 21, EmployeeID = 2 };

            Employee employee3 = new Employee()
            { BirthDate = new DateTime(1998, 11, 22), VacationStock = 21, EmployeeID = 3 };

            Department department1 = new Department()
            {
                DeptID = 1,
                DeptName = "SD"
            };

            Club club = new Club() { ClubID = 1, ClubName = "Club" };

            SalesPerson s01 = new SalesPerson()
            {
                AchievedTarget = 22,
                BirthDate = new DateTime(1997, 3, 22),
                VacationStock = 21,
                EmployeeID = 4
            };

            BoardMember B01 = new BoardMember()
            {
                EmployeeID = 5
            };

            club.AddMember(employee1);
            club.AddMember(employee2);
            club.AddMember(employee3);
            club.AddMember(s01);
            club.AddMember(B01);

            department1.AddStaff(employee1);
            department1.AddStaff(employee2);
            department1.AddStaff(employee3);
            department1.AddStaff(s01);
            department1.AddStaff(B01);

            employee1.RequestVacation
               (new DateTime(2020, 3, 2), new DateTime(2020, 3, 30));

            employee2.EndOfYearOperation();

            s01.CheckTarget(50);

            B01.Resign();


        }
    }
}