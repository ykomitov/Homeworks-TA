namespace MvcExam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using MvcExam.Common;
    using MvcExam.Data.Models;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            const string AdministratorUserName = "admin@admin.com";
            const string AdministratorPassword = AdministratorUserName;
            const string SampleUserName = "user1@site.com";
            const string SampleUserPassword = "user1";
            const string SampleIpAddress = "172.16.254.1";

            string[] ideaTitles = new string[]
            {
                "XNA 5",
                "Allow .NET games on Xbox One",
                "Support web.config style Transforms on any file in any project type",
                "Bring back Macros",
                "Open source Silverlight",
                "Native DirectX 11 support for WPF",
                "Make WPF open-source and accept pull-requests from the community",
                "Fix 260 character file name length limitation",
                "Support for ES6 modules",
                "Create a \"remove all remnants of Visual Studio from your system\" program.",
                "Support .NET Builds without requiring Visual Studio on the server",
                "VS IDE should support file patterns in project files",
                "Improve WPF performance",
                "T4 editing",
                "Visual Studio for Mac Os x"
            };

            string[] ideaDescriptions = new string[]
            {
                "Please continue to work on XNA. It's a great way for indie game developers like myself to make games and give them to the world. XNA gave us the ability to put our games, easily, on the most popular platforms, and to just dump XNA would be therefor heartbreaking... I implore you to keep working on XNA so we C# developers can still make amazing games!",
                "Yesterday was announced that Xbox One will allow indie developer to easily publish games on Xbox One." + System.Environment.NewLine + "Lots of indie developers and small game company are using .NET to develop games.Today, we are able to easily target several Windows platforms(Windows Desktop, Windows RT and Windows Phone 8) as well as other platforms thanks to Mono from Xamarin." + System.Environment.NewLine + "As we don't know yet the details about this indie developer program for Xbox One, we would love to use .NET on this platform - with everything accessible, from latest 4.5 with async, to unsafe code and native code access through DLLImport (and not only through WinRT components)" + System.Environment.NewLine + "Please make .NET a compelling game development alternative on Xbox One!",
                "Web.config Transforms offer a great way to handle environment-specific settings. XML and other files frequently warrant similar changes when building for development(Debug), SIT, UAT, and production(Release).It is easy to create additional build configurations to support multiple environments via transforms.Unfortunately, not everything can be handled in web.config files many settings need to be changed in xml or other \"config\" files." + System.Environment.NewLine + "Also, this functionality is needed in other project types - most notably SharePoint 2010 projects.",
                "I am amazed you've decided to remove Macros from Visual Studio. Not only are they useful for general programming, but they're a great way to be introduced to the Visual Studio APIs." + System.Environment.NewLine + "If you are unwilling to put in the development time towards them, please release the source code and let the community maintain it as an extension.",
                "For all intents and purposes Microsoft now views Silverlight as “Done”. While it is no longer in active development it is still being “supported” through to 2021 (source)." + System.Environment.NewLine + "However there is still a section of the .Net community that would like to see further development done on the Silverlight framework. A quick look at some common request lists brings up the following stats:",
                "in 2013 WPF still work on DX9, and this have a lot of inconvenience. First of all it is almost impossible to make interaction with native DX11 C++ and WPF. Axisting D3DImage class support only DX 9, but not higher and for now it is a lot of pain to attach DX 11 engine to WPF." + System.Environment.NewLine + "Please, make nativa support for DX 11 in WOF by default and update D3DImage class to have possibility to work with nativa C++ DX 11 engine and make render directly to WPF control(controls) without pain with C++ dll.",
                "Please follow the footsteps of the ASP .NET team and make WPF open-source with the source code on GitHub, and accept pull-requests from the community.",
                "Same description as here: http://visualstudio.uservoice.com/forums/121579-visual-studio/suggestions/2156195-fix-260-character-file-name-length-limitation",
                "Add support for the new JavaScript ES6 module syntax, including module definition and imports.",
                "I'm writing this on behalf of the thousands of other Visual Studio users out there who have had nightmares trying to uninstall previous versions of VS. Thus cumulatively losing hundreds of thousands of productive work hours." + System.Environment.NewLine + "During this year, I had installed the following programs/components on my system:" + System.Environment.NewLine + "*Visual Studio 2012 Express for Desktop" + System.Environment.NewLine + "* Visual Studio 2012 Express for Web" + System.Environment.NewLine + "* Team Foundation Server Express" + System.Environment.NewLine + "* SQL Server Express" + System.Environment.NewLine + "* SQL Server Data Tools" + System.Environment.NewLine + "* LightSwitch 2011 trial(which created a VS 2010 installation)" + System.Environment.NewLine + "* Visual Studio 2010 Tools for SQL Server Compact 3.5 SP2" + System.Environment.NewLine + "* Entity Framework Designer for Visual Studio 2012" + System.Environment.NewLine + "* Visual Studio Tools for Applications" + System.Environment.NewLine + "* Visual Studio Tools for Office" + System.Environment.NewLine + "* F# Tools for Visual Studio Express 2012 for Web" + System.Environment.NewLine + "Two weeks ago I discovered that third - party controls can't be added to the Express versions of VS. I'm disabled and live on a fixed income, so spending $500 for the Professional version, in order to continue my hobby programming with a third-party control, was a tough decision. But I bought it." + System.Environment.NewLine + "When it arrived, I figured it would take an hour or two to remove the above programs and then I could install the Pro version. I wanted to have a clean file system and Registry for the new install of VS Pro." + System.Environment.NewLine + "It's now SIX DAYS later, and my spending 12-14 hours a day working on this alone. Removing these programs was the biggest nightmare I have ever faced with Microsoft products in my 30 years of being a Microsoft customer. Each one of these products automatically installed 5, 10 or more additional components, along with many thousands of files and individual Registry entries." + System.Environment.NewLine + "It took me four days alone, just to successfully remove the LightSwitch 2011 trial, and the entire VS 2010 product it installed.Restoring a 600 GB disk drive(5 hours) from backup after every removal attempt failed miserably.I finally gave up, spent 6 hours downloading the entire VS 2010 ISO and installed it. Only then, was I able to successfully uninstall LightSwitch 2011 and VS 2010." + System.Environment.NewLine + "As for the remaining products listed above, the uninstall programs do NOT UNinstall everything that they automatically INstall. Every single, automatically INstalled component, had to be removed manually, one at a time.Along with manually creating a System Restore point before each removal attempt, in case it failed. In total, I spent 12 hours uninstalling the remaining products." + System.Environment.NewLine + "I have a Registry search program where I can enter a search string and it will list ALL occurrences it finds in the Registry. I checked \"visual studio\", \"visualstudio\", \"vbexpress\", \"vcexpress\", \"SQL Server\", etc.I never finished searching for all the possible Visual Studio and SQL Server strings because the results being returned were eye - popping.Each search was returning 1, 000, 3, 000, even 7, 000 individual Registry entries that had NOT been removed by the individual uninstall processes.This is TENS of THOUSANDS of never to be used again Registry entries that these programs simply left behind.The size of my Registry file is now a stunning 691 MB!" + System.Environment.NewLine + "All of this frustration and wasted time is completely avoidable!And my case is not \"isolated\".There are hundreds of thousands of hits on Google regarding this problem, that point to Microsoft forums, MS Blog sites, and many independent Windows developer support forums on the web." + System.Environment.NewLine + "Microsoft really should provide an uninstall program that actually works, by UNinstalling everything it INstalls-- for each product it sells-- including Visual Studio.The downloadable(from Microsoft) uninstall program for VS 2010 does not work correctly and does not remove everything that VS 2010 installs." + System.Environment.NewLine + "When a program installs multiple individual components, tens of thousands of files and Registry entries, it SHOULD have an uninstaller that removes ALL of this, automatically, just like the install program.The OS and Registry keep track of dependencies and you folks know what the removal order should be for all of these products.So the team that creates the INstall program for each product, should also create the UNinstall program.And, the product should NOT ship until this program works correctly and fully." + System.Environment.NewLine + "You have ONE install program for each version of Visual Studio, that asks the user what they want to install and then does it ALL automatically.You should also have ONE uninstall program that does the same thing in reverse..." + System.Environment.NewLine + "* Collect info on all the VS - related products and components currently installed" + System.Environment.NewLine + "* Ask the user what they want to remove" + System.Environment.NewLine + "* Determine if their selections make sense" + System.Environment.NewLine + "* Check for dependencies by using your knowledge and experience, along with the computer's stored information, and warn the user as needed" + System.Environment.NewLine + "* Decide on the removal order" + System.Environment.NewLine + "*Then do it ALL automatically-- removing ALL files and ALL Registry entries" + System.Environment.NewLine + "When you release a new product version, ADD the new version and additional decision logic to this existing program, do NOT create a new uninstall program.This way, the user can also remove previous version products, components, etc.ONE uninstall program* should be* able to uninstall every version of Visual Studio released in the past 10 years, along with every single component that was available with it, AND all of the associated files and Registry entries." + System.Environment.NewLine + "Please don't tell us why it CAN'T be done.Rather, figure out a way to do it, and then make it happen, just like every other software company out there has already done for their products. Even FREEware providers have better uninstall processes than Microsoft.This is a sad state for Microsoft and it should be rectified SOON." + System.Environment.NewLine + "Thank you.",
                "To build certain PCL libraries and libraries for Windows 8 RT requires having Visual Studio on the server." + System.Environment.NewLine + "Nick Berardi writes about a workaround that allows running a build server without VS, but it's really just a workaround for functionality that should be easy." + System.Environment.NewLine + "Not to mention there's probably licensing considerations we're just ignoring by doing that." + System.Environment.NewLine + "http://nickberardi.com/a-net-build-server-without-visual-studio/" + System.Environment.NewLine + "Please make it easy(and legal) to build.NET projects on a server without requiring a Visual Studio installation(or license) on that server.",
                "Patterns should be preserved and unmodified when working with *proj files. If I specify a pattern with something like **/*.cs for my code files. If I add a new .cs file that fits that pattern the .csproj file should not be modified." + System.Environment.NewLine + "MSBuild already respects this, but the IDE will always modify the project file." + System.Environment.NewLine + "For numerous scenarios this could simplify the diff / merge process.",
                "I have a high end PC and still WPF is not always fluent. Just compare it with QT 4.6 QML (Declarative UI) it is sooo FAST!",
                "T4 is no longer just a tool used internally by VS, but is being increasingly used by developers for code generation. It would be great to have syntax highlighting, intellisense etc. out of the box." + System.Environment.NewLine + "I appreciate this is probably more of a Visual Studio feature request than an ASP.NET one, but as T4 is used a lot within ASP.NET projects, particularly MVC ones, I figure it's worth a mention.",
                "Dear Madam and sir;" + System.Environment.NewLine + "We need Full Version of Visual Studio for Mac Os x." + System.Environment.NewLine + "And language of programming such as:" + System.Environment.NewLine + "-C" + System.Environment.NewLine + "- C++" + System.Environment.NewLine + "- C#" + System.Environment.NewLine + "- VB" + System.Environment.NewLine + "- F#" + System.Environment.NewLine + "- HTML" + System.Environment.NewLine + "- MHTML" + System.Environment.NewLine + "Thanks,"
            };

            if (!context.Roles.Any())
            {
                // Create admin & user roles
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var adminRole = new IdentityRole { Name = GlobalConstants.AdministratorRoleName };
                roleManager.Create(adminRole);

                // Create admin user
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var admin = new ApplicationUser { UserName = AdministratorUserName, Email = AdministratorUserName };
                userManager.Create(admin, AdministratorPassword);

                // Assign user to admin role
                userManager.AddToRole(admin.Id, GlobalConstants.AdministratorRoleName);

                // Create simple user
                var passwordHash = new PasswordHasher();
                string password = passwordHash.HashPassword(SampleUserPassword);
                context.Users.AddOrUpdate(
                    u => u.UserName,
                    new ApplicationUser { UserName = SampleUserName, PasswordHash = password, Email = SampleUserName });
                context.SaveChanges();

                string userId = context.Users.Where(x => x.Email == SampleUserName && string.IsNullOrEmpty(x.SecurityStamp)).Select(x => x.Id).FirstOrDefault();

                // If the userId is not null, then the SecurityStamp needs updating.
                if (!string.IsNullOrEmpty(userId))
                {
                    userManager.UpdateSecurityStamp(userId);
                }

                context.SaveChanges();

                // Add sample ideas
                for (int i = 0; i < 15; i++)
                {
                    Idea newIdea = new Idea()
                    {
                        Title = ideaTitles[i],
                        Description = ideaDescriptions[i],
                        AuthorIp = SampleIpAddress
                    };

                    context.Ideas.Add(newIdea);
                    context.SaveChanges();
                }

                // Add sample comments
                for (int i = 1; i <= 15; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        var newComment = new Comment()
                        {
                            IdeaId = i,
                            Content = "Sample content for comment " + j,
                            Email = "sample@email.com"
                        };

                        context.Comments.Add(newComment);
                    }

                    context.SaveChanges();
                }

                // Add sample votes
                for (int i = 1; i <= 15; i++)
                {
                    for (int j = 1; j <= 101; j++)
                    {
                        var newVote = new Vote()
                        {
                            IdeaId = i,
                            AuthorIp = RandomGenerator.GetRandomIp(),
                            VotePoints = RandomGenerator.GetRandomVotePoints()
                        };

                        context.Votes.Add(newVote);

                        if (j % 10 == 0)
                        {
                            context.SaveChanges();
                        }
                    }

                    context.SaveChanges();
                }
            }
        }
    }
}
