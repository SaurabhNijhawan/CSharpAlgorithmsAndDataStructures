using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferenceTrackManagement
{
    internal class ConferenceManagement
    {
        public static Conference ManageConference(Queue<Talk> talks)
        {
            // Initialize Conference Data Structure
            var tracks = InitializeEmptyTracks();
            var conference = new Conference(tracks);

            //Loop through all Talks and assign them to empty Talk slots in Sessions

            while (talks.Count != 0)
            {
                var currentTalk = talks.Dequeue();
                foreach (var track in conference.Tracks)
                {
                    // Morning Session
                    if (!track.MorningSession.Filled)
                    {
                        if ((currentTalk.Duration) <= track.MorningSession.EndTime - track.MorningSession.CurrentTime)
                        {
                            track.MorningSession.Talks.Enqueue(currentTalk);
                            track.MorningSession.CurrentTime = track.MorningSession.CurrentTime + currentTalk.Duration;
                            break;
                        }
                        track.MorningSession.Filled = true;
                    }

                    // AfterNoon Session
                    if (!track.AfterNoonSession.Filled)
                    {
                        if (currentTalk.Duration <= track.AfterNoonSession.EndTime - track.AfterNoonSession.CurrentTime)
                        {
                            track.AfterNoonSession.Talks.Enqueue(currentTalk);
                            track.AfterNoonSession.CurrentTime = track.AfterNoonSession.CurrentTime
                                                                 + currentTalk.Duration;
                            break;
                        }
                        track.AfterNoonSession.Filled = true;
                    }

                    var allTracksFilled = true;
                    foreach (var track1 in tracks)
                    {
                        if (!track1.Filled)
                        {
                            allTracksFilled = false;
                        }
                    }

                    if (talks.Count() != 0 && allTracksFilled)
                    {
                        foreach (var track1 in tracks)
                        {
                            track1.Filled = false;
                        }
                    }
                }
            }

            // Marks Track as filled and adds Networking event at the end of each Track
            foreach (var track in conference.Tracks)
            {
                if (track.AfterNoonSession.Filled)
                {
                    if (track.Filled != true)
                    {
                        track.AfterNoonSession.Talks.Enqueue(new Talk() { Name = "Networking Event" });
                        track.Filled = true;
                    }
                }
            }

            PrintTalkSchedule(conference);
            return conference;
        }

        /// <summary>
        /// Prints the schedule of the Talks in the conference
        /// </summary>
        /// <param name="conference"></param>
        private static void PrintTalkSchedule(Conference conference)
        {
            foreach (var track in conference.Tracks)
            {
                Console.WriteLine();
                Console.WriteLine("TRACK: " + track.Id);
                while (track.MorningSession.Talks.Count != 0)
                {
                    var talk = track.MorningSession.Talks.Dequeue();
                    Console.WriteLine(
                        string.Format(
                            "{0}:{1}", track.MorningSession.StartTime / 60, track.MorningSession.StartTime % 60)
                        + " AM " + talk.Name);
                    track.MorningSession.StartTime = track.MorningSession.StartTime + talk.Duration;
                }

                Console.WriteLine();
                Console.WriteLine("12:00 PM LUNCH");
                Console.WriteLine();

                while (track.AfterNoonSession.Talks.Count != 0)
                {
                    var talk = track.AfterNoonSession.Talks.Dequeue();
                    Console.WriteLine(
                        string.Format(
                            "{0}:{1}", track.AfterNoonSession.StartTime / 60, track.AfterNoonSession.StartTime % 60)
                        + " PM " + talk.Name);
                    track.AfterNoonSession.StartTime = track.AfterNoonSession.StartTime + talk.Duration;
                }
                if (track.Filled != true)
                {
                    Console.WriteLine(
                        string.Format(
                            "{0}:{1}", track.AfterNoonSession.StartTime / 60, track.AfterNoonSession.StartTime % 60)
                        + " PM " + "Networking Event");
                    track.Filled = true;
                }
            }
        }

        /// <summary>
        /// Initializes the Tracks with Default values
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Track> InitializeEmptyTracks()
        {
            var tracks = new List<Track>()
                {
                    new Track(1)
                        {
                            MorningSession = new Session(new Queue<Talk>(), 9 * 60, 12 * 60, 9 * 60),
                            AfterNoonSession = new Session(new Queue<Talk>(), 1 * 60, 5 * 60, 1 * 60)
                        },
                    new Track(2)
                        {
                            MorningSession = new Session(new Queue<Talk>(), 9 * 60, 12 * 60, 9 * 60),
                            AfterNoonSession = new Session(new Queue<Talk>(), 1 * 60, 5 * 60, 1 * 60)
                        }
                };
            return tracks;
        }
    }
}