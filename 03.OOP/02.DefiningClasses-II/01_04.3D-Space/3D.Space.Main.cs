namespace Space3D
{
    using System;

    class TestArea
    {
        static void Main()
        {
            /*### Problem 1. Structure
             * Create a structure `Point3D` to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
             * Implement the `ToString()` to enable printing a 3D point.*/

            Console.WriteLine("Problem 1. Structure - new 3D point created");
            Point3D point1 = new Point3D(1, 2, 3);
            Console.WriteLine(point1);

            /*### Problem 2. Static read-only field
             * Add a `private static read-only` field to hold the start of the coordinate system â€“ the point O{0, 0, 0}.
             * Add a static property to return the point O.*/
            Console.WriteLine("\r\n\r\n\r\nProblem 2. Static read-only field - Point O");
            Console.WriteLine(Point3D.PointO);
            Console.WriteLine();
            
            /*### Problem 3. Static class
             * Write a `static class` with a `static method` to calculate the distance between two points in the 3D space.*/
            Point3D point11 = new Point3D(-7, -4, 3);
            Point3D point22 = new Point3D(17, 6, 2.5);
            Console.WriteLine("\r\n\r\n\r\nProblem 3. Distance between points");
            Console.WriteLine(point11);
            Console.WriteLine(point22);
            Console.WriteLine();
            Console.WriteLine(CalculateDistance.Distance(point11, point22));
            Console.WriteLine("26.004807247892 <== hardcoded to check the calculation");

            /*### Problem 4. Path
             * Create a class `Path` to hold a sequence of points in the 3D space.
             * Create a static class `PathStorage` with static methods to save and load paths from a text file.
             * Use a file format of your choice.*/
            Console.WriteLine("\r\n\r\n\r\nProblem 4. Path Class");
            Path newPath = new Path();
            newPath.Add3DPoint(point11);
            newPath.Add3DPoint(point22);
            newPath.Add3DPoint(Point3D.PointO);

            Console.WriteLine("\r\nPoints stored in newPath:\r\n");
            Console.WriteLine(newPath);

            //Test point deletion
            newPath.Delete3DPoint(Point3D.PointO);

            Console.WriteLine("\r\nPoints stored in newPath after removal of Point O:\r\n");
            Console.WriteLine(newPath);

            //Test saving Path to file
            PathStorage.SavePath(newPath);

            //Test loading Path from file
            Console.WriteLine("\r\nTest loading Path from file\r\n");
            Path testInputFile = new Path();
            PathStorage.LoadPath(testInputFile);
            Console.WriteLine(testInputFile);

        }
    }
}
