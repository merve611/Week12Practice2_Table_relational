using Microsoft.EntityFrameworkCore;
using Week12Practice2_Table_relational.Entities;

namespace Week12Practice2_Table_relational.Context
{
    public class PatikaSecondDbContext:DbContext
    {
        //public DbSet<PostEntity> Posts { get; set; }
        //public DbSet<UserEntity> Users { get; set; }

        public DbSet<PostEntity> Posts => Set<PostEntity>();
        public DbSet<UserEntity> Users => Set<UserEntity>();

        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options):base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Bir kullanıcının birden fazla gönderisi olabilir, ancak her gönderi yanlızca bir kullanıcıya aittir
            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.HasMany(x => x.Posts)
                      .WithOne(x => x.User)
                      .HasForeignKey(x => x.UserId);


            });
        }

    }
}
