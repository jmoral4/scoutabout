using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScoutAboutData
{
    /// <summary>
    /// EF-framework User model
    /// </summary>
    public class User
    {
        public int UserId;

        [Required]
        public string Name;
    }
}
