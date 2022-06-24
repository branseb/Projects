using System.Text;

namespace Company
{
    public abstract class Employee
    {
        public readonly int Id;
        public readonly string Name;

        public DateOnly StartDate { get;private set; }

        public int Rate { get; set; }

        public Employee(int id, string name, DateOnly startdate, int rate)
        {
			if (rate < 0) {
				throw new ArgumentException("Rate cannot be negative");
			}

            Id = id;
            Name = name;
            StartDate = startdate;
            Rate = rate;
        }

        public virtual string GetInfo()
        {
            var info = new StringBuilder();
            info.AppendLine("ID: " + Id);
            info.AppendLine("Name: " + Name);
            info.AppendLine("Begin Work in Company: " + StartDate);
            info.AppendLine("Rate: " + Rate + "$");
            return info.ToString();
        }
        public void SetRate(int newrate)
        {
            Rate = newrate;
        }
    }
}
