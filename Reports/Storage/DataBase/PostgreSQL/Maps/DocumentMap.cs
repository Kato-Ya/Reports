using Reports.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Reports.Storage.DataBase.PostgreSQL.Maps
{
    public class DocumentMap : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("COMMENT");
            builder.Property(x => x.DocumentId).HasColumnName("DOCUMENT_ID");
            builder.Property(x => x.ReportId).HasColumnName("REPORT_ID");
            builder.Property(x => x.DocumentName).HasColumnName("DOCUMENT_NAME");
            builder.Property(x => x.DocumentFile).HasColumnName("DOCUMENT_FILE");

            builder.HasOne(t => t.Report).WithMany().HasForeignKey(fieldfromUser => fieldfromUser.ReportId);
        }
    }
}
