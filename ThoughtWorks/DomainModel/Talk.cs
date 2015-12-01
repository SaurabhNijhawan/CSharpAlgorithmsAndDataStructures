using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoughtWorks.DomainModel
{
    class Talk
    {
        public Talk(string name, int duration)
        {
            this.Name = name;
            this.Duration = duration;
        }
        public string Name { get; private set; }

        public int Duration { get; private set; }
    }
}
