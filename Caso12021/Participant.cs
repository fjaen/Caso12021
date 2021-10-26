using System;
using System.Collections.Generic;
using System.Text;

namespace Caso12021
{
    class Participant
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Broadcasting> Broadcastings { get; set; }

        public Participant()
        {
            Broadcastings = new List<Broadcasting>();
        }
        public Participant(string Name,string Phone, Broadcasting b):this()
        {
            this.Name = Name;
            this.PhoneNumber = Phone;
            this.Broadcastings.Add(b);
        }
    }
}
