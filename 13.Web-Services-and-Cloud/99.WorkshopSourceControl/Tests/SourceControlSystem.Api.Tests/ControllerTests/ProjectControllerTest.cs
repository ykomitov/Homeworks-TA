namespace SourceControlSystem.Api.Tests.ControllerTests
{
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Web.Http.Results;
    using Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models.Projects;
    using MyTested.WebApi;
    using Services.Data.Contracts;

    [TestClass]
    public class ProjectControllerTest
    {
        [TestMethod]
        public void PostShouldValidateModelState()
        {
            var controller = new ProjectsController(TestObjectFactory.GetProjectsService());
            controller.Configuration = new HttpConfiguration();

            var model = TestObjectFactory.GetInvalidModel();

            controller.Validate(model);
            var result = controller.Post(model);

            Assert.IsFalse(controller.ModelState.IsValid);
        }

        [TestMethod]
        public void PostShouldValidateModelStateByIvo()
        {
            MyWebApi
                .Controller<ProjectsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetProjectsService())
                .Calling(c => c.Post(TestObjectFactory.GetInvalidModel()))
                .ShouldHave()
                .InvalidModelState();
        }

        [TestMethod]
        public void PostShouldReturnBadRequestWithInvalidModel()
        {
            var controller = new ProjectsController(TestObjectFactory.GetProjectsService());
            controller.Configuration = new HttpConfiguration();

            var model = TestObjectFactory.GetInvalidModel();

            controller.Validate(model);
            var result = controller.Post(model);

            Assert.AreEqual(typeof(InvalidModelStateResult), result.GetType());
        }

        [TestMethod]
        public void PostShouldReturnBadRequestWithInvalidModelByIvo()
        {
            MyWebApi
                  .Controller<ProjectsController>()
                  .WithResolvedDependencyFor<IProjectsService>(TestObjectFactory.GetProjectsService())
                  .Calling(c => c.Get())
                  .ShouldReturn()
                  .Ok()
                  .WithResponseModelOfType<List<SoftwareProjectDetailsResponseModel>>();
        }

        [TestMethod]
        public void TestAuthorizedAttribute()
        {
            MyWebApi
                  .Controller<ProjectsController>()
                  .WithResolvedDependencyFor<IProjectsService>(TestObjectFactory.GetProjectsService())
                  .Calling(c => c.Get())
                  .ShouldHave()
                  .ActionAttributes(a => a.RestrictingForAuthorizedRequests());
        }
    }
}
