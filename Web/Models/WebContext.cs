using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class WebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
       

        public DbSet<Web.Models.User> Users { get; set; }

        public DbSet<Web.Models.Activity> Activities { get; set; }

        public DbSet<Web.Models.Guide> Guides { get; set; }

        public DbSet<Web.Models.Tag> Tags { get; set; }

        public DbSet<Web.Models.TypeOfDay> TypeOfDays { get; set; }

        public DbSet<Web.Models.Interest> Interests { get; set; }

        public DbSet<Web.Models.Item> Items { get; set; }
    }
}