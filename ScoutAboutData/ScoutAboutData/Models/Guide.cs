using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModeng System.ComponentModel.DataAnnotations;

namespace SActivitiytData.Models
{
    public class Guide
    {
        public int GuideId { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        [Required]
        public string Author { get; set; }

    }
}
