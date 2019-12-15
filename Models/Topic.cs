using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Topic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TopicID { get; set; }

        public string Subject { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
