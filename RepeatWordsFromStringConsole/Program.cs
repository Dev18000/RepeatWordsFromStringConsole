string path = "C:/text-data.txt";

using (StreamReader streamReaderForRead = File.OpenText(path))
{
    if (streamReaderForRead != null)
    {
        string streamTemps = "";
        while ((streamTemps = streamReaderForRead.ReadLine()) != null)
        {
            var stringBase = string.Join("\n", streamTemps);
            var stringBaseRepeat = new String('+', 3).Replace("+", $"{stringBase} ");

            Console.Write($" \n{stringBase} -> {stringBaseRepeat}");
        }
    }
}
