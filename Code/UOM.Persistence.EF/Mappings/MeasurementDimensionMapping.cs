using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Domain.Model.MeasurementDimensions;

namespace UOM.Persistence.EF.Mappings
{
    public class MeasurementDimensionMapping : EntityTypeConfiguration<MeasurementDimension>
    {
        public MeasurementDimensionMapping()
        {
            ToTable("MeasurementDimensions");
            Property(a => a.Title).HasMaxLength(50);
            Property(a => a.AlternateTitle).HasMaxLength(50);
            Property(a => a.Symbol).HasMaxLength(3);

        }
    }
}
