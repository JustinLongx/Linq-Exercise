namespace Linq_Exercise
    
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>()
            {
                "call of duty", "paladins", "osrs", "hghghghghghghghghghg", "a", "ab"

            };

            var videoGameLength = from games in videoGames
                                  where games.Length > 0
                                  orderby games.Length 
                                  select games;

            foreach (var i in videoGameLength)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

        }
    }
}
