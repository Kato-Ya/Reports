using Reports.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Reports.Storage.DataBase.PostgreSQL.Maps
{
    public class ReportMap : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.ToTable("REPORT");
            builder.Property(x => x.ReportId).HasColumnName("REPORT_ID");
            builder.Property(x => x.ReportName).HasColumnName("REPORT_NAME");
            builder.Property(x => x.ReportType).HasColumnName("REPORT_TYPE");
            builder.Property(x => x.ReportDescription).HasColumnName("REPORT_DESCRIPTION");
            builder.Property(x => x.AssignedTo).HasColumnName("ASSIGNED_TO");
            builder.Property(x => x.Deadline).HasColumnName("DEADLINE");
            builder.Property(x => x.Status).HasColumnName("STATUS");

            builder.HasOne(t => t.User).WithMany().HasForeignKey(x => x.AssignedTo);
        }
    }
}
