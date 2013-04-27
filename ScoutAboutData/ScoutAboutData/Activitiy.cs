using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutAboutData
{
    public class Activitiy
    {
        public string Title { get; set; }
        public string PlaceName { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public decimal Cost { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime {get;set;}
        public List<Tag> Tags { get; set; }            

    }
}
