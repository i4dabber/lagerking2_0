using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagerking.Model
{
    public class LagerkingDbContext : DbContext
    {
        public LagerkingDbContext()
            : base("name=PRJ4Entities")
        {

        }

        public virtual DbSet<DbProduktIndex> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
