namespace YouTubePlaylists.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<YoutubePlaylistsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        protected override void Seed(YoutubePlaylistsDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            UserStore<User> userStore = new UserStore<User>(context);
            UserManager<User> userManager = new UserManager<User>(userStore);
            var passwordHash = new PasswordHasher();

            string[] userNames = new string[]
            {
                "admin@site.com",
                "user1@site.com",
                "user2@site.com",
                "user3@site.com",
                "user4@site.com",
                "user5@site.com",
            };

            string[] userPasswords = new string[]
            {
                "admin",
                "user1",
                "user2",
                "user3",
                "user4",
                "user5",
            };

            for (int i = 0; i < userNames.Length; i++)
            {
                string password = passwordHash.HashPassword(userPasswords[i]);
                context.Users.AddOrUpdate(u => u.UserName,
                    new User()
                    {
                        UserName = userNames[i],
                        Email = userNames[i],
                        PasswordHash = password,
                        FirstName = "Test",
                        LastName = "User"
                    });


                context.SaveChanges();

                string uName = userNames[i];
                string userId = context.Users.Where(x => x.Email == uName && string.IsNullOrEmpty(x.SecurityStamp)).Select(x => x.Id).FirstOrDefault();

                //If the userId is not null, then the SecurityStamp needs updating.
                if (!string.IsNullOrEmpty(userId)) userManager.UpdateSecurityStamp(userId);

                context.SaveChanges();
            }

            for (int i = 0; i < 500; i++)
            {
                var randomCategoryName = RandomString(30);

                if (context.Categories.Any(c => c.Name == randomCategoryName))
                {
                    continue;
                }

                var newCategory = new Category()
                {
                    Name = randomCategoryName
                };

                context.Categories.Add(newCategory);
                context.SaveChanges();
            }

            string[] youtubeVideos = new string[]
            {
                "https://www.youtube.com/embed/oPmKRtWta4E",
                "https://www.youtube.com/embed/XQEBzauVIlA",
                "https://www.youtube.com/embed/FBmkFYym9hE",
                "https://www.youtube.com/embed/cW2bqBhP4AA",
                "https://www.youtube.com/embed/CDl9ZMfj6aE",
                "https://www.youtube.com/embed/04F4xlWSFh0",
                "https://www.youtube.com/embed/UclCCFNG9q4",
                "https://www.youtube.com/embed/Aym9-pzfvbA",
                "https://www.youtube.com/embed/qqrnLkEFxKw",
                "https://www.youtube.com/embed/c18441Eh_WE",
                "https://www.youtube.com/embed/zI339U6GS9s",
                "https://www.youtube.com/embed/9ro0FW9Qt-4",
                "https://www.youtube.com/embed/weRHyjj34ZE",
                "https://www.youtube.com/embed/p47fEXGabaY",
                "https://www.youtube.com/embed/8BkYKwHLXiU",
                "https://www.youtube.com/embed/lBztnahrOFw",
                "https://www.youtube.com/embed/KxcP7TRY178",
                "https://www.youtube.com/embed/Cydzolb0eIs",
                "https://www.youtube.com/embed/q4v1nDa7tLY",
                "https://www.youtube.com/embed/EdP19wnPPoY",
                "https://www.youtube.com/embed/Z2_rwr_qEkA",
                "https://www.youtube.com/embed/l46yY9pGghY",
                "https://www.youtube.com/embed/zWj2N2wp07s",
                "https://www.youtube.com/embed/XAIX2vISe3M",
                "https://www.youtube.com/embed/Q8gi_yLF8r8",
                "https://www.youtube.com/embed/hDy1LyGZmiY",
                "https://www.youtube.com/embed/-Gw1SHWMmDs",
                "https://www.youtube.com/embed/UCCpdI8vd5I",
                "https://www.youtube.com/embed/FMYmzcgZqZw",
                "https://www.youtube.com/embed/yf-rfClPFwA",
                "https://www.youtube.com/embed/Vkt-Ey6Wl8E",
                "https://www.youtube.com/embed/AHXv_IWLmzw",
                "https://www.youtube.com/embed/mek_03oNTeI",
                "https://www.youtube.com/embed/fqcSO0zT2Sg",
                "https://www.youtube.com/embed/mek_03oNTeI",
                "https://www.youtube.com/embed/fqcSO0zT2Sg",
                "https://www.youtube.com/embed/mek_03oNTeI",
                "https://www.youtube.com/embed/fqcSO0zT2Sg",
                 };

            int videoCounter = 0;
            for (int i = 0; i < 11; i++)
            {
                var randomCategory = context.Categories.OrderBy(qu => Guid.NewGuid()).First();
                var randomUser = context.Users.OrderBy(qu => Guid.NewGuid()).First();
                var playList = new Playlist()
                {
                    Title = "Playlist " + (i + 1),
                    DateCreated = DateTime.Now,
                    Description = "Description for Playlist" + (i + 1),
                    CategoryId = randomCategory.Id,
                    CreatorId = randomUser.Id
                };

                for (int j = 0; j < 3; j++)
                {
                    playList.Videos.Add(new Video() { Url = youtubeVideos[videoCounter] });
                    videoCounter++;
                }

                context.Playlists.Add(playList);
                context.SaveChanges();
            }

            Random rnd = new Random();
            for (int i = 0; i < 300; i++)
            {
                var rating = rnd.Next(1, 6);
                var randomUser = context.Users.OrderBy(qu => Guid.NewGuid()).First();
                var randomPlaylist = context.Playlists.OrderBy(qu => Guid.NewGuid()).First();

                if (context.Ratings.Any(r => r.PlaylistId == randomPlaylist.Id && r.UserId == randomUser.Id))
                {
                    continue;
                }

                var createdRating = new Rating()
                {
                    PlaylistId = randomPlaylist.Id,
                    UserId = randomUser.Id,
                    Value = rating
                };

                context.Ratings.Add(createdRating);
                context.SaveChanges();
            }
        }
    }
}
