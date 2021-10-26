using System;
using System.Collections.Generic;
using System.Text;

namespace Caso12021
{
    class Conductor:Participant
    {
        public double FixedSalary { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }

        public Conductor() : base()
        {
            Contracts = new List<Contract>();
        }

        //Relaxed Constructor Contract not passed as parameter
        public Conductor(string Name, string Phone, Broadcasting b, double FixedSalary):base(Name,Phone,b)
        {
            Contracts = new List<Contract>();
            this.FixedSalary = FixedSalary;
        }
    }
}
