
using Dal;
using Entities;

namespace Bll
{
    public class PopulationJellyFishService
    {
        private readonly PopulationJellyFishRepository populationJellyFishRepository;

        public PopulationJellyFishService()
        {
            populationJellyFishRepository = new PopulationJellyFishRepository();
        }
        
        public IEnumerable<int> GetPopulationPredicted(int AddDaysToPopulation)
        {
            try
            {
                var populationJellyFish = CreateAndSetPopulation(AddDaysToPopulation);
                return populationJellyFish.CurrentPopulation;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public int GetAmountPopulation(int AddDaysToPopulation)
        {
            try
            {
                var populationJellyFish = CreateAndSetPopulation(AddDaysToPopulation);
                return populationJellyFish.GetCurrentPopulation();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        private PopulationJellyFish CreateAndSetPopulation(int AddDaysToPopulation)
        {
            IList<int> initialPopulation = populationJellyFishRepository.GetPopulationOfFile();
            PopulationJellyFish populationJellyFish = new PopulationJellyFish();
            populationJellyFish.AddRange(initialPopulation);
            populationJellyFish.IncrementDaysToPopulation(AddDaysToPopulation);
            return populationJellyFish;
        }
        
    }
}