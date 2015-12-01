using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceTrackManagement
{
    class Conference
    {
        private readonly List<Track> tracks = new List<Track>(); 

        public Conference(IEnumerable<Track> tracks)
        {
            this.tracks = tracks.ToList();
        }

        public IEnumerable<Track> Tracks
        {
            get
            {
                return this.tracks;
            }
        } 
    }
}
