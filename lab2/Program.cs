using lab2;

Employee emp1 = new Employee();
emp1.ID = 1;
emp1.Name = "Aya";
emp1.Salary = 2000;
emp1.HireDate = new HiringDate(12, 5, 2021);
emp1.EmpGender = Gender.F;
emp1.SecurityLevel = SecurityLevel.DBA;

Console.WriteLine(emp1);

Employee emp2 = new Employee(2, "Ibrahim", SecurityLevel.securityOfficer, 1000, new HiringDate(1, 12, 2020), Gender.M);
Console.WriteLine(emp2);

Employee[] empArr = new Employee[3];
empArr[0] = emp1;
empArr[2] = emp2;
empArr[1] = new Employee(3, "Ahmed", SecurityLevel.guest, 1500, new HiringDate(10, 2, 2019), Gender.M);
Console.ForegroundColor = ConsoleColor.Yellow;
foreach (Employee emp in empArr)
    Console.WriteLine(emp);
Console.ResetColor();

Array.Sort(empArr);
Console.ForegroundColor = ConsoleColor.Green;
foreach (Employee emp in empArr)
    Console.WriteLine(emp);
Console.ResetColor();

Console.ReadLine();


