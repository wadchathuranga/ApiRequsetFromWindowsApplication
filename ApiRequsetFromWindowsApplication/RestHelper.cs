using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiRequsetFromWindowsApplication
{
    public static class RestHelper
    {

        public static readonly string baseURL = "https://reqres.in/api/";

        public static async Task<string> GetAsync()
        {
            var client = new HttpClient();

            var response = await client.GetAsync(baseURL + "users");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                if (result != null)
                {
                    //new JsonSerializer().Deserialize<dynamic>(result);
                    return result;
                }

            }

            return string.Empty;
        }
    }
}
