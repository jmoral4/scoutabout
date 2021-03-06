﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string PlaceName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public decimal? Cost { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public int Hour
        {
            get
            {
                if (StartTime.HasValue)
                {
                    return StartTime.Value.Hour;
                }
                else
                {
                    return -9999;
                }
            }
        }

        public int Height
        {
            get
            {
                return (DurationInHours * 40);
            }
        }

        public int DurationInHours
        {
            get
            {
                if (Duration.HasValue)
                {
                    return (int)Math.Ceiling(Duration.Value.TotalHours);
                }
                else
                {
                    return 1;
                }
            }
        }

        public string GoogleLink
        {
            get
            {
                const string GoogleAddressStart = "https://www.google.com/search?q=";
                string ret = "http://portland.startupweekend.org/";
                if (!string.IsNullOrEmpty(PlaceName))
                    ret = GoogleAddressStart + PlaceName.Replace(" ", "+").Trim();

                return ret;
            }
        }
    }
}
