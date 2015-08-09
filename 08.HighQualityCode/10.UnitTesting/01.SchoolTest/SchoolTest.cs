namespace _01.SchoolTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _01.Students_and_courses;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingStudentWithEmptyNameShouldThrow()
        {
            var someStudent = new Student("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingStudentWithNullNameShouldThrow()
        {
            var someStudent = new Student(null);
        }

        [TestMethod]
        public void CreatingStudentsShouldIncreaseLastUsedIdCount()
        {
            // Arrange
            var initialID = 9999;
            var numberOfStudentsToAdd = 10;
            List<Student> studentList = new List<Student>();

            // Act
            for (int i = 0; i < numberOfStudentsToAdd; i++)
            {
                studentList.Add(new Student("Student" + i));
            }

            // Assert
            Assert.AreEqual(initialID + numberOfStudentsToAdd, studentList[numberOfStudentsToAdd - 1].StudentID);
        }

        [TestMethod]
        public void AddingTwoStudentsToCourseShouldWork()
        {
            // Arrange
            var someCourse = new Course("TestCourse");

            // Act
            someCourse.StudentJoin(new Student("Gosho"));
            someCourse.StudentJoin(new Student("Pesho"));

            // Assert
            Assert.AreEqual(2, someCourse.GetNumberOfStudentsInCourse());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddingThirtyTwoStudentsToCourseShouldThrow()
        {
            // Arrange
            var someCourse = new Course("TestCourse");
            var numberOfStudentsToAdd = 32;

            // Act
            for (int i = 0; i < numberOfStudentsToAdd; i++)
            {
                someCourse.StudentJoin(new Student("Student" + i));
            }
        }

        [TestMethod]
        public void RemovingStudentFromCourseShouldWork()
        {
            // Arrange
            var someCourse = new Course("TestCourse");
            var theStudent = new Student("RemoveMe");
            var numberOfStudentsToAdd = 5;

            // Act
            for (int i = 0; i < numberOfStudentsToAdd; i++)
            {
                someCourse.StudentJoin(new Student("Student" + "Batch 1" + i));
            }

            someCourse.StudentJoin(theStudent);

            for (int i = 0; i < numberOfStudentsToAdd; i++)
            {
                someCourse.StudentJoin(new Student("Student" + "Batch 2" + i));
            }

            someCourse.StudentLeave(theStudent);

            // Assert
            Assert.AreEqual(2 * numberOfStudentsToAdd, someCourse.GetNumberOfStudentsInCourse());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddingMoreThanMaxNumberOfStudentsShouldThrow()
        {
            // Arrange
            int numberOfAddedStudents = 0;
            int numberOfCoursesAdded = 0;
            int maxNumberOfStudentsInCourse = 30;
            List<Course> courseList = new List<Course>();

            // Act
            while (numberOfAddedStudents < 90000)
            {
                var course = new Course("Course" + numberOfCoursesAdded);


                numberOfCoursesAdded++;

                for (int i = 0; i < maxNumberOfStudentsInCourse; i++)
                {
                    course.StudentJoin(new Student("Student " + i));
                    numberOfAddedStudents++;
                }

                courseList.Add(course);
            }
        }
    }
}
