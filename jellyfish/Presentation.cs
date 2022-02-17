using Bll;
using Entities;

namespace jellyfish;

public class Presentation
{
    private PopulationJellyFishService populationJellyFishService;

    public Presentation()
    {
        populationJellyFishService = new PopulationJellyFishService();
    }
    
    public void TestInitialPopulation()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        var testInitialPopulation = new List<int> {3, 4, 3, 1, 2};
        var populationJellyFish = new PopulationJellyFish();
        populationJellyFish.AddRange(testInitialPopulation);
        populationJellyFish.IncrementDaysToPopulation(18);
        var populationInString = populationJellyFish.CurrentPopulation.ToList().ConvertAll(x=>x.ToString());
        string joinedPopulation = populationInString.Aggregate((x, y) => x + ", " + y);
        Console.WriteLine("Prueba Simulacion con el ejemplo en el documento de word: " + joinedPopulation);
    }
    
    public void PrintHowManyJellyFishWillThereBeIn80Days()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Primera Parte");
        Console.WriteLine($"La Cantidad de poblacion en 80 dias seria: {populationJellyFishService.GetAmountPopulation(80)}");
    }
    
    public void PrintHowManyJellyFishWillThereBeIn256Days()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Segunda Parte");
        Console.WriteLine($"La Cantidad de poblacion en 256 dias seria: {populationJellyFishService.GetAmountPopulation(170)}");
    }
}