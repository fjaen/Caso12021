using System;
using System.Collections.Generic;
using System.Text;

namespace Caso12021
{
    class Contract
    {
        public double ExtraSalary { get; set; }
        public virtual TVShow Show { get; set; }
        public virtual Conductor Conductor { get; set; }

        public Contract(double ExtraSalary,TVShow show, Conductor cond)
        {
            this.ExtraSalary = ExtraSalary;
            this.Show = show;
            this.Conductor = cond;
        }
    }
}
