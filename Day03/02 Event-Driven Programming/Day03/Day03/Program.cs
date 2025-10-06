namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // إنشاء قسم ونادي
            Department dept = new Department();
            Club club = new Club();

            // إنشاء موظفين بأنواع مختلفة
            Employee e1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1990, 1, 1), VacationStock = -10 };
            Employee e2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1950, 1, 1), VacationStock = 5 }; // عمره > 60
            SalesPerson s1 = new SalesPerson { EmployeeID = 3, BirthDate = new DateTime(1995, 1, 1), AchievedTarget = 50 };
            BoardMember b1 = new BoardMember { EmployeeID = 4, BirthDate = new DateTime(1940, 1, 1) };

            // إضافة الموظفين للقسم والنادي
            dept.AddStaff(e1);
            dept.AddStaff(e2);
            dept.AddStaff(s1);
            dept.AddStaff(b1);

            club.AddMember(e1);
            club.AddMember(e2);
            club.AddMember(s1);
            club.AddMember(b1);

            Console.WriteLine("=== Initial status ===");
            dept.ShowStaff();
            club.ShowMembers();

            // 🔹 1) موظف يطلب إجازة أكبر من رصيده
            Console.WriteLine("\n--- Scenario 1: More leave than balance vacation ---");
            e1.RequestVacation(DateTime.Today, DateTime.Today.AddDays(10));

            dept.ShowStaff();
            club.ShowMembers();

            // 🔹 2) نهاية السنة (يتم فحص السن أو الرصيد)
            Console.WriteLine("\n---Scenario 2: EndOfYearOperation ---");
            e1.EndOfYearOperation();
            e2.EndOfYearOperation();
            s1.EndOfYearOperation();
            b1.EndOfYearOperation();

            dept.ShowStaff();
            club.ShowMembers();

            // 🔹 3) مندوب المبيعات يفشل في تحقيق الهدف
            Console.WriteLine("\n--- Scenario 3: SalesPerson Fails to Target ---");
            s1.CheckTarget(100);

            dept.ShowStaff();
            club.ShowMembers();

            // 🔹 4) عضو مجلس الإدارة يستقيل
            Console.WriteLine("\n--- Scenario 4: Board Member Resigns ---");
            b1.Resign();

            dept.ShowStaff();
            club.ShowMembers();

            Console.WriteLine("\n=== END ===");
        }
    }
}
