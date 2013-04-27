using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScoutAboutData
{
    public class Guide
    {
        public virtual ICollection<Activity> Activities { get; set; }
        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        [Required]
        public string Author { get; set; }

    }
}
