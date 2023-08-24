using BubbleSortExample;


IList<int> GenerateRandomArray()
{
    var array = new int[10000];

    Random random = new();
    for (var i = 0; i < array.Length; i++)
    {
        // Genera números aleatorios entre 1 y 100000
        var randomValue = random.Next(1, 100001);
        array[i] = randomValue;
    }

    return array;
}


var array = GenerateRandomArray();
var elapsedMilliSeconds = BubbleSort.Sort(array);
foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.WriteLine("\nTiempo de ejecución en milisegundos: " + elapsedMilliSeconds);