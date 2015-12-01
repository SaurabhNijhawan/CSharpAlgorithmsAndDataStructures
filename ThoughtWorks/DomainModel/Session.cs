using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.DomainModel
{
    class Session
    {
        public Session(IEnumerable<Talk> talks, int startTimeInMinutes, int endTimeInMinutes)
        {
            this.Talks = talks;
            this.StartTimeInMinutes = startTimeInMinutes;
            this.EndTimeInMinutes = endTimeInMinutes;
        }
        public IEnumerable<Talk> Talks { get; set; }
        public int StartTimeInMinutes { get; set; }
        public int EndTimeInMinutes { get; set; }
    }
}
