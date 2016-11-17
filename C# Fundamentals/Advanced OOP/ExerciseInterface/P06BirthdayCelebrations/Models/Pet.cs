using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P06BirthdayCelebrations.Interfaces;

namespace P06BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        private string name;

        public Pet(string name, string birthDate)
        {
            this.name = name;
            this.BirthDate = birthDate;
        }

        public string BirthDate { get; set; }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public override string ToString()
        {
            return this.BirthDate;
        }
    }
}
