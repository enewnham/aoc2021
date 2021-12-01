var lines = await File.ReadAllLinesAsync("input.txt");
var depths = lines.Select(int.Parse).ToList();

var previousDepth = int.MaxValue;
var increases = 0;
foreach (var d in depths)
{
    if (d > previousDepth)
        increases++;
    previousDepth = d;
}

Console.WriteLine($"Increases={increases}");

previousDepth = int.MaxValue;
increases = 0;
for (var ii = 0; ii < depths.Count - 2; ii++)
{
    var window = depths.Skip(ii).Take(3);
    var sum = window.Sum();

    if (sum > previousDepth)
        increases++;
    previousDepth = sum;
}

Console.WriteLine($"Sum Increases={increases}");