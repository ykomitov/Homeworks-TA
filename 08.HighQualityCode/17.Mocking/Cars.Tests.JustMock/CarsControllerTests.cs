namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    using Infrastructure;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
             //:this(new JustMockCarsRepository())
             : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(4, model.Id);
            Assert.AreEqual("Opel", model.Make);
            Assert.AreEqual("Astra", model.Model);
            Assert.AreEqual(2010, model.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GettingCarDetailsOfNonexistingCarShouldThrowArgumentNullException()
        {
            var car = new Car
            {
                Id = 666,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Details(car.Id));
        }

        [TestMethod]
        public void SortingCarsByMakeShouldSortTheCarsCorrectly()
        {
            IList<Car> collectionSortedByMake = new List<Car>
            {
                new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 },
                new Car { Id = 2, Make = "BMW", Model = "325i", Year = 2008 },
                new Car { Id = 3, Make = "BMW", Model = "330d", Year = 2007 },
                new Car { Id = 4, Make = "Opel", Model = "Astra", Year = 2010 },
            };

            IList<Car> testCollection = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            for (var i = 0; i < testCollection.Count - 1; i++)
            {
                Assert.IsTrue(collectionSortedByMake[i].Make == testCollection[i].Make);
            }
        }

        [TestMethod]
        public void SortingCarsByYearShouldSortTheCarsCorrectly()
        {
            IList<Car> collectionSortedByMake = new List<Car>
            {
                new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 },
                new Car { Id = 3, Make = "BMW", Model = "330d", Year = 2007 },
                new Car { Id = 2, Make = "BMW", Model = "325i", Year = 2008 },
                new Car { Id = 4, Make = "Opel", Model = "Astra", Year = 2010 },
            };

            IList<Car> testCollection = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            for (var i = 0; i < testCollection.Count - 1; i++)
            {
                Assert.IsTrue(collectionSortedByMake[i].Year == testCollection[i].Year);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GSortingByInvalidParameterShouldThrow()
        {
            IList<Car> testCollection = (IList<Car>)this.GetModel(() => this.controller.Sort("Hanku Brat"));
        }

        [TestMethod]
        public void SearchingOfBmwShouldWorkCorrectly()
        {
            IList<Car> collectionOfBmws = new List<Car>
            {
                new Car { Id = 3, Make = "BMW", Model = "330d", Year = 2007 },
                new Car { Id = 2, Make = "BMW", Model = "325i", Year = 2008 },
            };

            IList<Car> testCollection = (IList<Car>)this.GetModel(() => this.controller.Search("Bmw"));

            for (var i = 0; i < testCollection.Count - 1; i++)
            {
                Assert.IsTrue(collectionOfBmws[i].Make == testCollection[i].Make);
            }
        }

        [TestMethod]
        public void SearchingOf330dShouldWorkCorrectly()
        {
            IList<Car> collectionOfBmws = new List<Car>
            {
                new Car { Id = 3, Make = "BMW", Model = "330d", Year = 2007 },
            };

            IList<Car> testCollection = (IList<Car>)this.GetModel(() => this.controller.Search("330d"));

            for (var i = 0; i < testCollection.Count - 1; i++)
            {
                Assert.IsTrue(collectionOfBmws[i].Model == testCollection[i].Model);
            }
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
