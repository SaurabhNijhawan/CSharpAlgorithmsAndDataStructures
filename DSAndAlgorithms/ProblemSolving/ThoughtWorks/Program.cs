//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConferenceTrackManagement
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var talks = new Queue<Talk>();
//            talks.Enqueue(new Talk() { Duration = 60, Name = "Writing Fast Tests Against Enterprise Rails 60min" });
//            talks.Enqueue(new Talk() { Duration = 45, Name = "Overdoing it in Python 45min" });
//            talks.Enqueue(new Talk() { Duration = 30, Name = "Lua for the Masses 30min" });
//            talks.Enqueue(new Talk() { Duration = 45, Name = "Ruby Errors from Mismatched Gem Versions 45min" });
//            talks.Enqueue(new Talk() { Duration = 45, Name = "Common Ruby Errors 45min" });
//            talks.Enqueue(new Talk() { Duration = 5, Name = "Rails for Python Developers lightning" });
//            talks.Enqueue(new Talk() { Duration = 60, Name = "Communicating Over Distance 60min" });
//            talks.Enqueue(new Talk() { Duration = 45, Name = "Accounting-Driven Development 45min" });
//            talks.Enqueue(new Talk() { Duration = 30, Name = "Woah 30min" });
//            talks.Enqueue(new Talk() { Duration = 30, Name = "Sit Down and Write 30min" });
//            talks.Enqueue(new Talk() { Duration = 45, Name = "Pair Programming vs Noise 45min" });
//            talks.Enqueue(new Talk() { Duration = 60, Name = "Rails Magic 60min" });
//            talks.Enqueue(new Talk() { Duration = 60, Name = "Ruby on Rails: Why We Should Move On 60min" });
//            talks.Enqueue(new Talk() { Duration = 45, Name = "Clojure Ate Scala (on my project) 45min" });
//            talks.Enqueue(new Talk() { Duration = 30, Name = "Programming in the Boondocks of Seattle 30min" });
//            talks.Enqueue(new Talk() { Duration = 30, Name = "Ruby vs. Clojure for Back-End Development 30min" });
//            talks.Enqueue(new Talk() { Duration = 60, Name = "Ruby on Rails Legacy App Maintenance 60min" });
//            talks.Enqueue(new Talk() { Duration = 30, Name = "A World Without HackerNews 30min" });
//            talks.Enqueue(new Talk() { Duration = 30, Name = "User Interface CSS in Rails Apps 30min" });

//            ConferenceManagement.ManageConference(talks);
//        }
//    }
//}
