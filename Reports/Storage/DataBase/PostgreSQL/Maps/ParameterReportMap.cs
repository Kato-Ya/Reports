using Reports.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reports.Storage.DataBase.PostgreSQL.Maps
{
    public class ParameterReportMap : IEntityTypeConfiguration<ParameterReport>
    {
        public void Configure(EntityTypeBuilder<ParameterReport> builder)
        {
            builder.ToTable("COMMENT");
            builder.Property(x => x.ReportId).HasColumnName("REPORT_ID");
            builder.Property(x => x.ParameterName).HasColumnName("PARAMETER_NAME");
            builder.Property(x => x.ParameterValue).HasColumnName("PARAMETER_VALUE");

            builder.HasOne(t => t.Report).WithMany().HasForeignKey(fieldfromUser => fieldfromUser.ReportId);
        }
    }
}
