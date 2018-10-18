using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Domain.Model.MeasurementDimensions;
using UOM.Persistence.EF.Mappings;

namespace UOM.Persistence.EF
{
    public class UomContext : DbContext
    {
        public DbSet<MeasurementDimension> MeasurementDimensions { get; set; }
        public UomContext() : base("DBConnection")
        {
            Database.SetInitializer<UomContext>(null);
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(MeasurementDimensionMapping).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
