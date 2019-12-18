using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models.MeetingViewModels
{
    public class MeetingIndexData
    {
        public IEnumerable<Meeting> Meetings { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
       
    }
}
