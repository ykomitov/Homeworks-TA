namespace ForumSystem.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

            // TODO: Remove in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var tagList = new List<Tag>();

            if (!context.Feedbacks.Any())
            {
                for (int i = 1; i <= 18; i++)
                {
                    var feedback = new Feedback()
                    {
                        Content = $"Feedback <b>content</b> {i}",
                        Title = $"Feedback {i}"
                    };

                    context.Feedbacks.Add(feedback);
                }

                context.SaveChanges();
            }

            if (!context.Tags.Any())
            {
                for (int i = 1; i <= 20; i++)
                {
                    var tag = new Tag()
                    {
                        Name = $"Tag {i}"
                    };

                    tagList.Add(tag);
                    context.Tags.Add(tag);
                }

                var tagIndex = 0;
                for (int i = 1; i <= 20; i++)
                {
                    var post = new Post()
                    {
                        Content = $"Post content {i}",
                        Title = $"Post title {i}"
                    };

                    for (int j = 0; j < 5; j++)
                    {
                        post.Tags.Add(tagList[tagIndex % tagList.Count]);
                        tagIndex++;
                    }

                    context.Posts.Add(post);
                }

                context.SaveChanges();
            }
        }
    }
}
