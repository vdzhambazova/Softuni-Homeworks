using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BroderControl
{
    public class Citizen: IIdentifiable
    {
        string name;
        int age;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
        }

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

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Id { get; set; }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
