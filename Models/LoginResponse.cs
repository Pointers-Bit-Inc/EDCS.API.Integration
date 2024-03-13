using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EDCS.API.Integration.Models
{
    public class LoginResponse
    {
        [JsonPropertyName("token")]
        public string AccessToken { set; get; }
    }
}
