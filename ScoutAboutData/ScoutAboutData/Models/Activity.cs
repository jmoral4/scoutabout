using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutAboutData.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string PlaceName { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public decimal Cost { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime {get;set;}
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }   

    }
}
