using SacramentPlanner.Models;
using System;
using System.Linq;

namespace SacramentPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Speakers.Any())
            {
                return;   // DB has been seeded
            }

            var speakers = new Speaker[]
            {
            new Speaker{FirstName="Carson",LastName="Alexander"},
            new Speaker{FirstName="Meredith",LastName="Alonso"},
            new Speaker{FirstName="Arturo",LastName="Anand"},
            new Speaker{FirstName="Gytis",LastName="Barzdukas"},
            new Speaker{FirstName="Yan",LastName="Li"},
            new Speaker{FirstName="Peggy",LastName="Justice"},
            new Speaker{FirstName="Laura",LastName="Norman"},
            new Speaker{FirstName="Nino",LastName="Olivetto"}
            };
            foreach (Speaker s in speakers)
            {
                context.Speakers.Add(s);
            }
            context.SaveChanges();

            var topics = new Topic[]
            {
            new Topic{TopicID=1050,Subject="Prayer"},
            new Topic{TopicID=4022,Subject="Scripture Study"},
            new Topic{TopicID=4041,Subject="Gratitude"},
            new Topic{TopicID=1045,Subject="Faith"},
            new Topic{TopicID=3141,Subject="Family"},
            new Topic{TopicID=2021,Subject="Dangers of Vaping"},
            new Topic{TopicID=2042,Subject="Articles of Faith"}
            };
            foreach (Topic t in topics)
            {
                context.Topics.Add(t);
            }
            context.SaveChanges();

            var assignments = new Assignment[]
            {
            new Assignment{SpeakerID=1,TopicID=1050,SpeechDate=DateTime.Parse("2005-09-01")},
            new Assignment{SpeakerID=1,TopicID=4022,SpeechDate=DateTime.Parse("2002-09-01")},
            new Assignment{SpeakerID=1,TopicID=4041,SpeechDate=DateTime.Parse("2003-09-01")},
            new Assignment{SpeakerID=2,TopicID=1045,SpeechDate=DateTime.Parse("2002-09-01")},
            new Assignment{SpeakerID=2,TopicID=3141,SpeechDate=DateTime.Parse("2002-09-01")},
            new Assignment{SpeakerID=2,TopicID=2021,SpeechDate=DateTime.Parse("2001-09-01")},
            new Assignment{SpeakerID=3,TopicID=1050,SpeechDate=DateTime.Parse("2001-09-01")},
            new Assignment{SpeakerID=4,TopicID=1050,SpeechDate=DateTime.Parse("2001-09-01")},
            new Assignment{SpeakerID=4,TopicID=4022,SpeechDate=DateTime.Parse("2001-09-01")},
            new Assignment{SpeakerID=5,TopicID=4041,SpeechDate=DateTime.Parse("2001-09-01")},
            new Assignment{SpeakerID=6,TopicID=1045,SpeechDate=DateTime.Parse("2001-09-01")},
            new Assignment{SpeakerID=7,TopicID=3141,SpeechDate=DateTime.Parse("2001-09-01")},
            };
            foreach (Assignment a in assignments)
            {
                context.Assignments.Add(a);
            }
            context.SaveChanges();
        }
    }
}
