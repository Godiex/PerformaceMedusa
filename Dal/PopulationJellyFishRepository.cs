using System.Reflection;
using Entities;

namespace Dal;

public class PopulationJellyFishRepository
{
        private const string PATH = @"../../../../../Medusas(1).txt";
       
        public IList<int> GetPopulationOfFile()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var fileStream = new FileStream(basePath+ PATH, FileMode.OpenOrCreate);
            var streamReader = new StreamReader(fileStream);
            string? line = streamReader.ReadLine();
            var initialPopulation = MapPopulation(line);
            streamReader.Close();
            fileStream.Close();
            return initialPopulation;
        }

        private static IList<int> MapPopulation(string linea)
        {
            var data = linea.Split(',');
            return data.ToList().ConvertAll(int.Parse);
        }
        
}