using Reports.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Reports.Storage.DataBase.PostgreSQL.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USER");
            builder.Property(x => x.UserId).HasColumnName("USER_ID");
            builder.Property(x => x.UserName).HasColumnName("USER_NAME");
            builder.Property(x => x.Password).HasColumnName("PASSWORD");
            builder.Property(x => x.RoleId).HasColumnName("ROLE_ID");
            builder.Property(x => x.Login).HasColumnName("LOGIN");
            builder.Property(x => x.Status).HasColumnName("STATUS");

            builder.HasOne(t => t.Role).WithMany().HasForeignKey(t => t.RoleId);
        }
    }
}
