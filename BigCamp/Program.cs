internal class Program
{
    private static void Main(string[] args)
    {
        string[] bigCamp =
        {
            "Walmart", "State Grid Corporation of China", "Sinopec Group",
            "China National Petroleum Corporation", "Toyota Motor",
            "Volkswagen", "Royal Dutch Shell","Apple", "Berkshire Hathaway"
            , "Exxon Mobil"
        };

        var index = 0;
        while ((index < bigCamp.Length) && (bigCamp[index] != "Apple"))
        {
            index++;
        }

        Console.WriteLine("Apple is #{0} in the top 10 ", index + 1);


        Console.ReadKey();
    }
}