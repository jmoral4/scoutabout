using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class Guide
    {
        public int GuideId { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }

        public int? Likes { get; set; }
        public int? Follow { get; set; }
        public int? Shares { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public User Author { get; set; }

    }
}
