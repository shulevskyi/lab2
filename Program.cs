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












var startNode = new Node(43, 12);
var endNode = new Node(26, 27);


List<Node> openSet = new List<Node> ();
HashSet<Node> closedSet = new HashSet<Node> ();
openSet.Add(startNode);


void GetShortestPath(string[,] map, Node start, Node target)
{

    while (openSet.Count > 0)

    {
        Node curerentNode;
        curerentNode = openSet[0];

        for (int i = 1; i < openSet.Count; i++)
        {
            if (openSet[i].FCost < curerentNode.FCost ||
                openSet[i].FCost == curerentNode.FCost && openSet[i].HCost < curerentNode.HCost)
            {
                curerentNode = openSet[i];
                Console.Write(curerentNode.FCost);
            }  
        }

        openSet.Remove(curerentNode);
        closedSet.Add(curerentNode);

        if (curerentNode == target) // path has been found
        {
            Console.Write("Path has been found");
            return;
        }

        foreach (Node neighbor in Node.GetNeighbors(curerentNode, map))
        {
            if (!neighbor.IsTraversable(map) || closedSet.Contains(neighbor))
            {
                continue;
            }
        }

        
    }

}


GetShortestPath(map, startNode, endNode);