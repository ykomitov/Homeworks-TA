namespace SourceControlSystem.Api.Tests.RouteTests
{
    using System.Net.Http;
    using System.Web.Http;
    using Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models.Projects;
    using MyTested.WebApi;

    [TestClass]
    public class ProjectControllerRouteTests
    {
        [TestInitialize]
        public void Init()
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            MyWebApi.IsUsing(WebApiConfig.Config);
        }

        [TestMethod]
        public void PostShouldMapCorrectly()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Projects")
                .WithHttpMethod(HttpMethod.Post)
                .WithJsonContent(@"{ ""Name"":""Test"", ""Private"": true }")
                .To<ProjectsController>(a => a.Post(new SaveProjectRequestModel
                {
                    Name = "Test",
                    Private = true
                }));
        }
    }
}
