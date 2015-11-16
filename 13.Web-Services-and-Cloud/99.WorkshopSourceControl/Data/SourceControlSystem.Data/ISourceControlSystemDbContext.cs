namespace SourceControlSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public interface ISourceControlSystemDbContext
    {
        IDbSet<Commit> Commits { get; set; }

        IDbSet<SoftwareProject> SoftwareProjects { get; set; }

        int SaveChanges();

        void Dispose();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
