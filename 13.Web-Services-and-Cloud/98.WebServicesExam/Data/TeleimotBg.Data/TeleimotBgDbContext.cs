namespace TeleimotBg.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class TeleimotBgDbContext : IdentityDbContext<User>, ITeleimotBgDbContext
    {
        public TeleimotBgDbContext()
            : base("TeleimotBg", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<RealEstate> RealEstates { get; set; }

        public virtual IDbSet<UserRating> UserRatings { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }

        public static TeleimotBgDbContext Create()
        {
            return new TeleimotBgDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            ////modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
        }
    }
}
