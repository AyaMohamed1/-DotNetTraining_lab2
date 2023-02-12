using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public struct Employee : IComparable {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public int Salary { get; set; }
        public HiringDate HireDate { get; set; }
        private Gender _empGender;

        public Gender EmpGender
        {
            get => _empGender;
            set => _empGender = value;
        }

        public Employee(int ID, string Name, SecurityLevel SecurityLevel, int Salary, HiringDate HireDate, Gender EmpGender) {
            this.ID = ID;
            this.Name = Name;
            this.SecurityLevel = SecurityLevel;
            this.Salary = Salary;
            this.HireDate = HireDate;
            this._empGender = EmpGender;
        }

        public override string ToString() {
            string emp = $"Employee id: {ID}\nName: {Name}\nSecurityLevel: {SecurityLevel}\n" +
                $"Salary: {Salary}$\nHireDate: {HireDate}\nGender: {EmpGender}\n";
            return emp;
        }

        public int CompareTo(object incomingobject) {
            Employee incomingemployee = (Employee) incomingobject;
            return this.HireDate.Date.CompareTo(incomingemployee.HireDate.Date);
            //return this.ID.CompareTo(incomingemployee.ID);
        }



    }
}
