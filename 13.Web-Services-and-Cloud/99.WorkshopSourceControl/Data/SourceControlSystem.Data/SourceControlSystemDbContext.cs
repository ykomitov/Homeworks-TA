﻿namespace SourceControlSystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class SourceControlSystemDbContext : IdentityDbContext<User>
    {
        public SourceControlSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Commit> Commits { get; set; }

        public virtual IDbSet<SoftwareProject> SoftwareProjects { get; set; }

        public static SourceControlSystemDbContext Create()
        {
            return new SourceControlSystemDbContext();
        }
    }
}
