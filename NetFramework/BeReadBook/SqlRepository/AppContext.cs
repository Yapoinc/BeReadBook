using Model.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRepository
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=sqlDbBookContext")
        {
            Database.SetInitializer<AppContext>(null);//entity framework without migrations

            // this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().ToTable("Test");

        }
    }
}
