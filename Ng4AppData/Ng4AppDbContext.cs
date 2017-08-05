namespace Ng4AppData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Ng4AppDbContext : DbContext
    {
        public Ng4AppDbContext() : base("name=Ng4AppDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Thought> Thoughts { get; set; }
    }
}
