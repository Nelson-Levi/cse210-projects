using System;

class Program
{
    static void Main(string[] args)
    {
        
    }

    public class Employee
    {
        private string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public virtual double CalculatePay()
        {
            return 0;
        }
    }

    public class Salary : Employee
    {
        private int _months;
        private int _rate;

        public Salary(string name, int months, int rate)
          : base(name)
        {
            _months = months;
            _rate = rate;
        }

        public override double CalculatePay()
        {
            return _months * _rate;
        }
    }

    public class Hourly : Employee
    {
        private double _hours;
        private double _wage;

        public Hourly(string name, double hours, double wage)
         : base(name)
        {
            _hours = hours;
            _wage = wage;
        }

        public override double CalculatePay()
        {
            return _hours * _wage;
        }
    }

    public class Volunteer : Employee
    {
        public Volunteer(string name)
         : base(name)
         {
         }
    }
}