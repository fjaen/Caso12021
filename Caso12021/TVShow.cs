using System;
using System.Collections.Generic;
using System.Text;

namespace Caso12021
{
    class TVShow
    {
        public string Name { get; set; }

        public virtual ICollection<Broadcasting> Broadcastings { get; set; }
        public virtual Broadcasting FirstBroadCasting { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }

        public TVShow()
        {
            Broadcastings = new List<Broadcasting>();
            Contracts = new List<Contract>();
        }

        //Constructor relaxed Contract not passed as parameter
        public TVShow(string Name):this()
        {
            this.Name = Name;
            
        }
    }
}
