/*  Problem 4. Path
  
    Create a class Path to hold a sequence of points in the 3D space.
    Create a static class PathStorage with static methods to save and load paths from a text file.
    Use a file format of your choice.*/

namespace Space3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    public class Path
    {
        private List<Point3D> pathSequence = new List<Point3D>();

        public List<Point3D> PathSequence
        {
            get
            {
                return this.pathSequence;
            }
            set
            {
                this.pathSequence = value;
            }
        }

        public void Add3DPoint(Point3D a)
        {
            this.PathSequence.Add(a);
        }

        public void Delete3DPoint(Point3D a)
        {
            this.PathSequence.Remove(a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var point in this.PathSequence)
            {
                sb.Append(point);
                sb.Append("\r\n");
            }
            return sb.ToString();
        }
    }

    public static class PathStorage
    {
        public static void SavePath(Path inputPath)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var point in inputPath.PathSequence)
            {
                sb.Append(point.X);
                sb.Append(", ");
                sb.Append(point.Y);
                sb.Append(", ");
                sb.Append(point.Z);
                sb.Append("\r\n");
            }
            string outputString = sb.ToString();

            StreamWriter writer = new StreamWriter("../../sample-path-output.txt");
            writer.Write(outputString);
            writer.Close();
            Console.WriteLine("File written successfully!");
        }

        public static void LoadPath(Path outputPath)
        {
            string filename = "../../sample-input.txt";
            StreamReader reader = new StreamReader(filename);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    double[] tempArr = line.Split(',').Select(c => double.Parse(c)).ToArray();
                    outputPath.Add3DPoint(new Point3D(tempArr[0], tempArr[1], tempArr[2]));
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("File loaded successfully!\r\n");
        }
    }
}