using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Core.Entities.Concrete
{
    public class TokenResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("error-codes")]
        public List<string> ErrorCodes { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }
    }
}
