
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace YouShouldListenLibrary.DataAccess;
internal class DbConnection
{
    private readonly IConfiguration _config;
    private readonly IMongoDatabase _db;
    private string _connectionId = "MongoDB";
    public string dbName { get; private set; }
    public string categorycollection { get; set; }

    public DbConnection(IConfiguration config)
    {
        _config = config;

    }
}
