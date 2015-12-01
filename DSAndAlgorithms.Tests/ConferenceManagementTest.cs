using System.Collections.Generic;
using ConferenceTrackManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    /// <summary>
    ///This is a test class for ConferenceManagementTest and is intended
    ///to contain all ConferenceManagementTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConferenceManagementTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes

        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //

        #endregion

        /// <summary>
        ///A test for ManageConference
        ///</summary>
        [TestMethod()]
        public void ManageConferenceTest()
        {
            var talks = new Queue<Talk>();
            talks.Enqueue(new Talk() { Duration = 60, Name = "Writing Fast Tests Against Enterprise Rails 60min" });
            talks.Enqueue(new Talk() { Duration = 45, Name = "Overdoing it in Python 45min" });
            talks.Enqueue(new Talk() { Duration = 30, Name = "Lua for the Masses 30min" });
            talks.Enqueue(new Talk() { Duration = 45, Name = "Ruby Errors from Mismatched Gem Versions 45min" });
            talks.Enqueue(new Talk() { Duration = 45, Name = "Common Ruby Errors 45min" });
            talks.Enqueue(new Talk() { Duration = 5, Name = "Rails for Python Developers lightning" });
            talks.Enqueue(new Talk() { Duration = 60, Name = "Communicating Over Distance 60min" });
            talks.Enqueue(new Talk() { Duration = 45, Name = "Accounting-Driven Development 45min" });
            talks.Enqueue(new Talk() { Duration = 30, Name = "Woah 30min" });
            talks.Enqueue(new Talk() { Duration = 30, Name = "Sit Down and Write 30min" });
            talks.Enqueue(new Talk() { Duration = 45, Name = "Pair Programming vs Noise 45min" });
            talks.Enqueue(new Talk() { Duration = 60, Name = "Rails Magic 60min" });
            talks.Enqueue(new Talk() { Duration = 60, Name = "Ruby on Rails: Why We Should Move On 60min" });
            talks.Enqueue(new Talk() { Duration = 45, Name = "Clojure Ate Scala (on my project) 45min" });
            talks.Enqueue(new Talk() { Duration = 30, Name = "Programming in the Boondocks of Seattle 30min" });
            talks.Enqueue(new Talk() { Duration = 30, Name = "Ruby vs. Clojure for Back-End Development 30min" });
            talks.Enqueue(new Talk() { Duration = 60, Name = "Ruby on Rails Legacy App Maintenance 60min" });
            talks.Enqueue(new Talk() { Duration = 30, Name = "A World Without HackerNews 30min" });
            talks.Enqueue(new Talk() { Duration = 30, Name = "User Interface CSS in Rails Apps 30min" });

            ConferenceManagement.ManageConference(talks);
        }

        [TestMethod()]
        public void ManageConferenceNoTalksTest()
        {
            var talks = new Queue<Talk>();
            var conference = ConferenceManagement.ManageConference(talks);
            foreach (var track in conference.Tracks)
            {
             Assert.IsTrue(track.MorningSession.Talks.Count == 0);
             Assert.IsTrue(track.AfterNoonSession.Talks.Count == 0);   
            }
        }

        [TestMethod()]
        public void ManageConferenceOneBigTalkTest()
        {
            var talks = new Queue<Talk>();
            talks.Enqueue(new Talk() { Duration = 300, Name = "User Interface CSS in Rails Apps 300min" });
            var conference = ConferenceManagement.ManageConference(talks);
            foreach (var track in conference.Tracks)
            {
                Assert.IsTrue(track.MorningSession.Talks.Count == 0);
                Assert.IsTrue(track.AfterNoonSession.Talks.Count == 0);
            }
        }
    }
}