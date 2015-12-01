using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace ThoughtWorks.DomainModel
{
    class Track
    {
        public Track(IEnumerable<Session> sessions)
        {
            this.Sessions = sessions;

        }
        public IEnumerable<Session> Sessions { get; set; }

        public int StartTimeInMinutes { get; set; }

        public int EndTimeInMinutes { get; set; }
    }
}
