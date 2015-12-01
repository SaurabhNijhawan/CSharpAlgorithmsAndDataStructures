using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoughtWorks.DomainModel
{
    class Conference
    {
        public Conference(IEnumerable<Track> tracks)
        {
            this.Tracks = tracks;
        }
        public IEnumerable<Track> Tracks { get; set; }
    }
}
