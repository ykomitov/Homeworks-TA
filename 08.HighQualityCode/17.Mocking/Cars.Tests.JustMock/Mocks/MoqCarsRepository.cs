﻿namespace Cars.Tests.JustMock.Mocks
{
    using Cars.Contracts;
    using Cars.Models;
    using Moq;
    using System;
    using System.Linq;

    public class MoqCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            mockedCarsRepository.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();
            mockedCarsRepository.Setup(r => r.All()).Returns(this.FakeCarCollection);
            mockedCarsRepository.Setup(r => r.Search(It.IsAny<string>())).Returns((string s) => this.FakeCarCollection.Where(c => c.Make.ToLower() == s.ToLower() || c.Model.ToLower() == s.ToLower()).ToList());
            mockedCarsRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns(this.FakeCarCollection.First());
            mockedCarsRepository.Setup(r => r.GetById(It.Is<int>(c => c == 666))).Returns((Car)null);
            mockedCarsRepository.Setup(r => r.SortedByMake()).Returns(this.FakeCarCollection.OrderBy(c => c.Make).ToList());
            mockedCarsRepository.Setup(r => r.SortedByYear()).Returns(this.FakeCarCollection.OrderBy(c => c.Year).ToList());
            this.CarsData = mockedCarsRepository.Object;
        }
    }
}
