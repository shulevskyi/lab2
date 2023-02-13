using ConsoleApp3;
using Microsoft.VisualBasic;

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


var startNode = new Node(43, 12, );

List<Node> openSet = new List<Node> {};
HashSet<Node> closedSet = new HashSet<Node> {};
openSet.Add(startNode);




void GetShortestPath(string[,] map, Point start, Point end)
{

    while (openSet.Count > 0)
    {
        // current = point in openSet with the lowest f_cost
        
        
    }

}


// Distance for current cell to the target cell
static double DistanceEnd(Point current_cell, Point end_cell)
{
    var xDiff = end_cell.Column - current_cell.Column;
    var yDiff = end_cell.Row - current_cell.Row;
    var distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
    return distance;
}


// Distance from the current cell to the start point
static double DistanceOrigin(Point current_cell, Point start_cell)
{
    var xDiff = current_cell.Column - start_cell.Column;
    var yDiff = current_cell.Row - start_cell.Row;
    var distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
    return distance;
}

//Console.Write(DistanceEnd(start, start));



//GetShortestPath(map, start, end);
//new MapPrinter().Print(map, path);

public Node(int value)
{
    Value = value;
}
