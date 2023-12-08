var filepath = "./data2.txt";

var sum = 0;

foreach(var line in await File.ReadAllLinesAsync(filepath))
{
    var firstDigit = line.First(char.IsDigit);
    var lastDigit =line.Last(char.IsDigit);

    sum += int.Parse(new string([firstDigit, lastDigit]));
}

Console.Write(sum);
