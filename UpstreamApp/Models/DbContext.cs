
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UpstreamApp.Models;

namespace ContosoUniversity.DAL
{
    public class UpstreamContext : DbContext
    {

        public UpstreamContext() : base("UpstreamContext")
        {
        }

        public DbSet<Clients> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}