using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZendeskApi_v2_Pcl.Responses
{
    public class ErrorResponse
    {
        [JsonProperty("error")]
        public string Text { get; set; }
    }
}
