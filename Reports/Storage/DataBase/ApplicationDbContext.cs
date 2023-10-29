using Microsoft.EntityFrameworkCore;
using Reports.Storage.DataBase.PostgreSQL.Maps;
using System.Reflection;
using Reports.Storage.Entities;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Reports.Storage.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<ParameterReport> ParameterReport { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        //для authservice в service
        //"var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Login == signInModel.Login);"
    }
}