using System;
using System.Data.Entity;
using System.Linq;

namespace FallingFruits.Models
{
    public class UserDBContext : DbContext
    {
        // Your context has been configured to use a 'UserDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FallingFruits.Models.UserDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UserDBContext' 
        // connection string in the application configuration file.
        public UserDBContext()
            : base("name=UserDBContext1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
    }
}