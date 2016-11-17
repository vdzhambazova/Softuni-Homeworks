using System;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        string[] studentDetails = Console.ReadLine().Split();
        string[] workerDetails = Console.ReadLine().Split();

        try
        {
            Student strudent = new Student(studentDetails[0], studentDetails[1], studentDetails[2]);
            Worker worker = new Worker(workerDetails[0], workerDetails[1],
                decimal.Parse(workerDetails[2]), decimal.Parse(workerDetails[3]));

            Console.WriteLine(strudent);
            Console.WriteLine(worker);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
            Environment.Exit(0);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (value.Substring(0, 1) != value.Substring(0, 1).ToUpper())
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.firstName)}");
                }
                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (value.Substring(0, 1) != value.Substring(0, 1).ToUpper())
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.lastName)}");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: {nameof(this.lastName)}");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");

            return sb.ToString();
        }

    }

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string FirstName
        {
            get { return base.FirstName; }
            protected set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(this.FirstName)}");
                }
                base.FirstName = value;
            }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                Regex regex = new Regex(@"^\w+\b$");
                Match match = regex.Match(value);
                if (match.Success || value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;


        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (1 > value && value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.WorkHoursPerDay)}");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.WeekSalary)}");
                }
                this.weekSalary = value;
            }
        }


        public decimal CalculateSalaryPerHour()
        {
            decimal salaryPerHour = this.weekSalary / this.workHoursPerDay / 5;
            return salaryPerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
            sb.AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():F2}");

            return sb.ToString();
        }
    }
}

