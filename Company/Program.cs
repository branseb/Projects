using Company;
var kros = new Company.Company("Blaznec s.r.o.");

var teacher1 = new Teacher(1, "Peter", new DateOnly(2022, 1, 1), 500);
var teacher2 = new Teacher(2, "Jana", new DateOnly(2022, 2, 1), 450);
var manager = new Manager(3, "Fero", new DateOnly(2021, 9, 1), 800, true, true, false);
kros.AddEmployee(teacher1);
kros.AddEmployee(teacher2);
kros.AddEmployee(manager);

foreach (var item in kros.Employees)
{
    Console.WriteLine(item.GetInfo());
}