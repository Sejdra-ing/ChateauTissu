using ChateauTissu.Services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChateauTissu.Services.Implementations
{
    public class Configuration : IConfiguration
    {
        public MongoClientSettings GetConnectionString(string v)
        {
            throw new NotImplementedException();
        }
    }
}