//N57-HT1

//- external configuration ga kirishi mumkin bo'lgan qiymatlarga misollar keltiring
//- configuration modelga yozishimiz mumkin bo'lgan ma'lumot tiplarini yozing

using System;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("My.json")
            .Build();

        int webPort = configuration.GetSection("AppSettings:WebPort").GetValue<int>();
        string dbHost = configuration.GetSection("AppSettings:DbConnection:Host").Value;
        int dbPort = configuration.GetSection("AppSettings:DbConnection:Port").GetValue<int>();
        string dbUser = configuration.GetSection("AppSettings:DbConnection:User").Value;
        string dbPassword = configuration.GetSection("AppSettings:DbConnection:Password").Value;
        string googleMapsApiKey = configuration.GetSection("AppSettings:GoogleMapsApiKey").Value;
        string logLevel = configuration.GetSection("AppSettings:LogLevel").Value;

        Console.WriteLine($"Web Port: {webPort}");
        Console.WriteLine($"DB Host: {dbHost}");
        Console.WriteLine($"DB Port: {dbPort}");
        Console.WriteLine($"DB User: {dbUser}");
        Console.WriteLine($"DB Password: {dbPassword}");
        Console.WriteLine($"Google Maps API Key: {googleMapsApiKey}");
        Console.WriteLine($"Log Level: {logLevel}");
    }
}
