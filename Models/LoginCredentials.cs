using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EDCS.API.Integration.Models
{
    public class LoginCredentials
    {
        [JsonPropertyName("userName")]
        public string UsernName { set; get; }
        [JsonPropertyName("password")]
        public string Password { set; get; }
    }
}
