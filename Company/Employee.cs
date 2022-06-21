using System.Text;

namespace Company
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateOnly StartDate { get; set; }

        public int Rate { get; set; }

        public Employee(int id, string name, DateOnly startdate, int rate)
        {
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
