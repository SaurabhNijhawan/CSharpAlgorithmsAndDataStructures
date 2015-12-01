using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.DomainModel;

namespace ThoughtWorks
{
    internal class ConferenceTrackManagement
    {
        public void ScheduleConference(List<Talk> talks)
        {
            talks = talks.OrderBy(talk => talk.Duration).ToList();

            var tracks = new List<Track>();
            var sessionsForTrack1 = new List<Session>();
            var s1ForT1 = new Session()
            sessionsForTrack1.Add(s1ForT1);
            var track1 = new Track(sessionsForTrack1);
            var track1 = new Track(sessionsForTrack1);

            var conference = new Conference(tracks);

        }

    }
}
