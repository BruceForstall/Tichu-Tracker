using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ScoreConverter
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    class Player
    {
        public int Id {get;set;}
        public string Name {get;set;}
    }
}