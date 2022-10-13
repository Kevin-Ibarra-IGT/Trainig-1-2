using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainign
{
    internal class Encap_ex
    {
        private string name { set; get; }
        private int age { set; get; }
        private string description { set; get; }

        private decimal salary;
        

        public decimal SalaryFullProperty
        {
            get { return salary; }
            set { 
            
                if (value < 0) { 
                    salary = 0;
                }
                else
                {
                    salary = value;
                } 
            
            }
        }


        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;            

        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int Age)
        {
            this.age = Age;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string Description)
        {
            this.description = Description;
        }



    }
}
