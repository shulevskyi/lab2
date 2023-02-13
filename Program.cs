using ConsoleApp3;

var generator = new MapGenerator(new MapGeneratorOptions()
{
    Height = 35,
    Width = 90,
});

string[,] map = generator.Generate();
new MapPrinter().Print(map);

List<Point> GetShortestPath(string[,] map, Point start, Point goal)
{
    // code here
    return null;
}

var start = new Point(43, 12);
var end = new Point(26, 27);

var path = GetShortestPath(map, start, end);

