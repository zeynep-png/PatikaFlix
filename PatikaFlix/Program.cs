
using PatikaFlix;

List<Series> seriesList = new List<Series>();

while (true)
{
    Series newSeries = new Series();

    Console.WriteLine("Series Name: ");
    newSeries.Name = Console.ReadLine();


    Console.WriteLine("Production Year: ");
    newSeries.ProductionYear = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Genre: ");
    newSeries.Genre = Console.ReadLine();


    Console.WriteLine("Realese Year: ");
    newSeries.ReleaseYear = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Director: ");
    newSeries.Director = Console.ReadLine();

    Console.WriteLine("Initial Platform: ");
    newSeries.InitialPlatform = Console.ReadLine();

    seriesList.Add(newSeries);

    Console.WriteLine("Would you like to add another series ? (y/n)");
    string ans = Console.ReadLine().ToLower();

    if (ans != "y")
        break;




}

List<ComedySeries> comedySeriesList = seriesList
                                      .Where(s => s.Genre =="Komedi" || s.Genre == "Comedy")
                                      .Select(s => new ComedySeries {  Name = s.Name, Genre = s.Genre, Director = s.Director })
                                      .OrderBy(s => s.Name)
                                      .ThenBy(s => s.Director)
                                      .ToList();

Console.WriteLine("\n------------Comedy Series List---------------\n");
foreach (var series in comedySeriesList)
    Console.WriteLine(series.Name + " - " + series.Genre + " - " + series.Director);
