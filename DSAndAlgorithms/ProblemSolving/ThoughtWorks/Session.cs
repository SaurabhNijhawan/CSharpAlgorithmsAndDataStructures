using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceTrackManagement
{
    class Session
    {
        public Session(Queue<Talk> talks, int startTime, int endTime, int currentTime)
        {
            this.Talks = talks;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.CurrentTime = currentTime;
        }

        
        public Queue<Talk> Talks { get; private set; }

        public int StartTime { get; set; }

        public int EndTime { get; private set; }

        
        public int CurrentTime { get; set; }

        public bool Filled { get; set; }
    }
}
