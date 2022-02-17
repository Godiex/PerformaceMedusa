
namespace Entities
{
    public class PopulationJellyFish
    {
        private const int NUMBER_DAYS_FOR_SPAM_FIRST_TIME = 8;
        private const int NUMBER_DAYS_FOR_SPAM = 6;
        public List<int> CurrentPopulation { get; set; }
        
        public PopulationJellyFish()
        {
            CurrentPopulation = new List<int>();
        }
        
        public void AddRange(IEnumerable<int> listDaysLeftToSpawn)
        {
            CurrentPopulation.AddRange(listDaysLeftToSpawn);
        }
        
        public int GetCurrentPopulation()
        {
            return CurrentPopulation.Count();
        }
        
        public void IncrementDaysToPopulation(int AddDaysToPopulation)
        {
            for (int i = 0; i < AddDaysToPopulation; i++)
            {
                UpdatePopulation();
            }
        }

        private void UpdatePopulation()
        {
            var lenght = CurrentPopulation.Count;
            for (int j = 0; j < lenght; j++)
            {
                if (CurrentPopulation[j] == 0)
                {
                    CurrentPopulation.Add(NUMBER_DAYS_FOR_SPAM_FIRST_TIME);
                    CurrentPopulation[j] = NUMBER_DAYS_FOR_SPAM;
                }
                else
                    CurrentPopulation[j] -= 1;
            }
        }
    }
    
}