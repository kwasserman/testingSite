global using Serilog;
using SpaBL;
using SpaDl;
using Model;


Log.Logger = new LoggerConfiguration().WriteTo.File("./logs/user.txt").CreateLogger();
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();
