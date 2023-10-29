using Reports.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Reports.Storage.DataBase.PostgreSQL.Maps
{
    public class NotificationMap : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable("COMMENT");
            builder.Property(x => x.NotificationId).HasColumnName("NOTIFICATION_ID");
            builder.Property(x => x.CreatedAt).HasColumnName("CREATED_AT");
            builder.Property(x => x.UserId).HasColumnName("USER_ID");
            builder.Property(x => x.IsRead).HasColumnName("IS_READ");
            builder.Property(x => x.CreatedAt).HasColumnName("CREATED_AT");
            builder.Property(x => x.NotificationName).HasColumnName("NOTIFICATION_NAME");

            builder.HasOne(t => t.User).WithMany().HasForeignKey(fieldfromUser => fieldfromUser.UserId);
        }
    }
}
