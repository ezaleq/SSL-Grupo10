using System.Diagnostics;

namespace BubbleSortExample;

public static class BubbleSort
{
    /// <summary>
    ///   Ordena un array de enteros de menor a mayor
    /// </summary>
    /// <param name="array">Lista de entero a ordenar</param>
    /// <returns>Tiempo transcurrido</returns>
    public static long Sort(IList<int> array)
    {
        Stopwatch time = new();
        time.Start();
        
        var len_arr = array.Count; // Longitud del array
        for (var i = 0; i < len_arr; i++)
        {
            // Primer loop
            for (var j = 0; j < len_arr - i - 1; j++)
            {
                // Segundo loop
                // Cambia > por < para orden descendente
                if (array[j] > array[j + 1])
                {
                    // Intercambio de elementos
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
        time.Stop();
        return time.ElapsedMilliseconds;
    }
}