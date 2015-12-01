using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceTrackManagement
{
    class Track
    {
        public Track(int id)
        {
            this.Id = id;
        }

        public Track(int id, Session morningSession, Session afterNoonSession)
        {
            this.Id = id;
            this.MorningSession = morningSession;
            this.AfterNoonSession = afterNoonSession;
        }
        public int Id { get; private set; }

        public Session MorningSession { get; set; }

        public Session AfterNoonSession { get; set; }

        public bool Filled { get; set; }
    }
}
