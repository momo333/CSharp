namespace DefiningClasses2
{
    using System;
    using System.IO;
    using System.Linq;
    public static class PathStorage
    {
        public static void WritePathFile(string location, Path path)
        {
            StreamWriter writer = new StreamWriter(location, false);
            using (writer)
            {
                writer.Write(path);
            }
        }
        public static Path ReadFromFile(string fileLocation)
        {
            Path loaded = new Path();
            StreamReader reader = new StreamReader(fileLocation);
            
            using (reader)
            {
                string line = reader.ReadLine();
                {
                    while(!string.IsNullOrEmpty(line))
                    {
                        line = line.Substring(line.IndexOf("-") + 4);
                        int[] coord = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        loaded.AddPoint(coord[0], coord[1], coord[2]);
                        line = reader.ReadLine();
                    }
                    return loaded;
                }
            }
            
        }
    }
}
