using System;
using System.Collections.Generic;
using System.Text;

namespace Caso12021
{
    class Broadcasting
    {
        public DateTime Date { get; set; }
        public virtual TVShow TvShow { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }

        public Broadcasting()
        {
            Participants = new List<Participant>();
        }

        //Constructor relaxed Participant not passed 
        public Broadcasting(DateTime d, TVShow show):this()
        {
            this.Date = d;
            this.TvShow = show;
         
        }
    }
}
