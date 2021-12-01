var depths = await File.ReadAllLinesAsync("input.txt");

var previousDepth = int.MaxValue;
var increases = 0;
foreach (var d in depths.Select(l => int.Parse(l)))
{
    if (d > previousDepth)
        increases++;
    previousDepth = d;
}

Console.WriteLine($"Increases={increases}");