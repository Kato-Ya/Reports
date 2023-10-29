using Reports.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Reports.Storage.DataBase.PostgreSQL.Maps
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("COMMENT");
            builder.Property(x => x.CommentId).HasColumnName("COMMENT_ID");
            builder.Property(x => x.ReportId).HasColumnName("REPORT_ID");
            builder.Property(x => x.UserId).HasColumnName("USER_ID");
            builder.Property(x => x.CommentText).HasColumnName("COMMENT_TEXT");
            builder.Property(x => x.CreatedAt).HasColumnName("CREATED_AT");

            builder.HasOne(t => t.Report).WithMany().HasForeignKey(fieldfromReport => fieldfromReport.ReportId);
            builder.HasOne(t => t.User).WithMany().HasForeignKey(fieldfromUser => fieldfromUser.UserId);
        }
    }
}
