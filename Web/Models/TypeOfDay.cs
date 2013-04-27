using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class TypeOfDay
    {
        public int TypeOfDayId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Interest> RelatedInterests { get; set; }
        public virtual ICollection<Tag> RelatedTags { get; set; }
    }
}
