using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SiteJson.Models;

namespace SiteJson.Data
{
    public static class Context
    {
        public static Site Site { get; set; }

        public static void Seed(string jsonData)
        {
            Site = JsonConvert.DeserializeObject<Site>(jsonData);
        }
    }
}
