namespace WindowsFormsApp20
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class Entitiy_model : DbContext
    {
        // Your context has been configured to use a 'Entitiy_model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WindowsFormsApp20.Entitiy_model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Entitiy_model' 
        // connection string in the application configuration file.
        public Entitiy_model()
            : base("name=Entitiy model")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }

    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Worker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}