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

var map = generator.Generate();
new MapPrinter().Print(map, path);

void GetShortestPath(string[,] map, Point start, Point end)
{


    for (int i = start.Column; i < map.GetLength(0); i++)
    {
        Point currentPoint = new Point(i, start.Row);
        if (map[currentPoint.Column, currentPoint.Row] == ".")
        {
            map[currentPoint.Column, currentPoint.Row] = "-";
        }
    }
}


GetShortestPath(map, start, end);
new MapPrinter().Print(map, path);
