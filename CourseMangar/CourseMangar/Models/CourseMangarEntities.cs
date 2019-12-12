namespace CourseMangar.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CourseMangarEntities : DbContext
    {
        public CourseMangarEntities()
            : base("name=CourseManagerContext")
        {
        }

        public virtual DbSet<Actionlinks> Actionlinks { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<CoursMangements> CoursMangements { get; set; }
        public virtual DbSet<Sidebars> Sidebars { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actionlinks>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<Actionlinks>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<Sidebars>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<Sidebars>()
                .Property(e => e.Action)
                .IsUnicode(false);
        }
    }
}
