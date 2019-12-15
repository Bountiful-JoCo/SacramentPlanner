using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        public int SpeakerID { get; set; }
        public int TopicID { get; set; }
        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime SpeechDate { get; set; }

        public Speaker Speaker { get; set; }
        public Topic Topic { get; set; }

    }
}
