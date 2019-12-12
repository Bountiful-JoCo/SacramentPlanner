using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter name using only letters, apostrophe or hyphen")]
        [Display(Name = "Conducting Leader")]
        [Required]
        public string ConductingLeader { get; set; }
        public string OpeningSong { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter name using only letters, apostrophe or hyphen")]
        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Sacrament Song")]
        public string SacramentSong { get; set; }
        [Display(Name = "Intermediate Song")]
        public string IntermediateSong { get; set; }
        [Display(Name = "Closing Song")]
        public string ClosingSong { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter name using only letters, apostrophe or hyphen")]
        [Display(Name = "Closing Prayer")]
        [Required]
        public string ClosingPrayer { get; set; }

        public ICollection<Speaker> Speakers { get; set; }

    }
}
