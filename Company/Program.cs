using Company;
using Logging;
var kros = new Company.Company("Blaznec s.r.o.");
var counter = 0;
var consolelogger = new ConsoleLogger();
var filelogger = new FileLogger("./log.txt");

var loggeradapter = new LoggerAdapter();
loggeradapter.AddLogger(consolelogger);
loggeradapter.AddLogger(filelogger);


kros.AddEmployee(new Company.Teacher(counter++, "Jozef", new DateOnly(1, 1, 1), 1000));

while (true)
{
	try
	{
		Console.WriteLine("Action: a-add, s-show, e-exit");
		var action = Console.ReadKey().KeyChar;
		Console.WriteLine();

		if (action == 'a')
		{
			Console.WriteLine("Name:");
			var name = Console.ReadLine() ?? "John Doe";

			Console.WriteLine("Rate:");
			var rateString = Console.ReadLine() ?? "0";
			var rate = int.Parse(rateString);

			Console.WriteLine("Role: t-teacher, m-manager");
			var role = Console.ReadKey().KeyChar;
			Console.WriteLine();

			switch (role)
			{
				case 't':
					var teacher = new Teacher(counter++, name, new DateOnly(), rate);
					kros.AddEmployee(teacher);
					break;
				case 'm':
					var manager = new Manager(counter++, name, new DateOnly(), rate, false, false, false);
					kros.AddEmployee(manager);
					break;
				default:
					throw new NotImplementedException("Role " + role + " is not implemented");
			}
		}
		else if (action == 's')
		{
			Console.WriteLine("-------------------------");
			foreach (var employee in kros.Employees)
			{
				Console.WriteLine(employee.GetInfo());
				Console.WriteLine("-------------------------");
			}
		}
		else if (action == 'e')
		{
			break;
		}
		else
		{
			throw new NotImplementedException("Action " + action + " is not implemented");
		}
	} 
	catch (Exception e) 
	{
		loggeradapter.Log(e);
	}
	finally
	{
		Console.WriteLine("End of cycle");
	}
}
