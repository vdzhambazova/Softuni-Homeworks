using System;
using System.Collections.Generic;
using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public static List<Private> privates = new List<Private>();

        public Private(string id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;

            privates.Add(this);
        }

        public double Salary { get; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}{Environment.NewLine}";
        }
    }
}