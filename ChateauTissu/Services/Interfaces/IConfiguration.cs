using MongoDB.Driver;

namespace ChateauTissu.Services.Interfaces
{
    public interface IConfiguration
    {
        MongoClientSettings GetConnectionString(string v);
    }
}