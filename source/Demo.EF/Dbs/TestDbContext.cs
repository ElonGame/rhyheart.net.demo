using Microsoft.EntityFrameworkCore;

namespace Demo.EF.Dbs
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().ToTable("classes");
            modelBuilder.Entity<Class>().Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Address>().ToTable("addresses");
            modelBuilder.Entity<Address>().Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Student>().ToTable("students");
            modelBuilder.Entity<Student>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Student>().HasOne(x => x.Class);
            modelBuilder.Entity<Student>().HasOne(x => x.Address);


            base.OnModelCreating(modelBuilder);
        }
    }
}
