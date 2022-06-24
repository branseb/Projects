using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
	public class Teacher : Employee
	{
		public readonly List<string> Subjects;

		public Teacher(int id, string name, DateOnly startdate, int rate) : base(id, name, startdate, rate)
		{
			Subjects = new List<string>();
		}

		public override string GetInfo()
		{
			var info = new StringBuilder();
			info.AppendLine(base.GetInfo());
			if (Subjects.Count > 0)
			{
				info.AppendLine("Subjects:");
				foreach (var item in Subjects)
				{
					info.AppendLine(item);
				}
			}
			else
				info.AppendLine("Teacher do not have Subjects.");
			return info.ToString();

		}
		public void AddSubjects(string subject)
		{
			Subjects.Add(subject);
		}
	}

}
