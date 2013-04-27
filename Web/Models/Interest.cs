using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Interest
    {
        public int InterestId { get; set; }
        public ICollection<Tag> RelatedTags { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
