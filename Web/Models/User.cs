using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Web.Models
{
    /// <summary>
    /// EF-framework User model
    /// </summary>
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
