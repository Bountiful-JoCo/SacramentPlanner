using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models.MeetingViewModels
{
    public class SpeechDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? SpeechDate { get; set; }

        public int SpeakerCount { get; set; }
    }
}
