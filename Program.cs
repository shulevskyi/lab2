using ConsoleApp3;

var generator = new MapGenerator(new MapGeneratorOptions()
{
    Height = 35,
    Width = 90,
});

var start = new Point(43, 12);
var end = new Point(26, 27);

// Coordinated of both start and end points
List<Point> path = new List<Point> {start, end};

string[,] map = generator.Generate();
new MapPrinter().Print(map, path);

List<Point> GetShortestPath(string[,] map, Point start, Point end)
{
    return null;
}

