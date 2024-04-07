using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiRequsetFromWindowsApplication
{
    public static class RestHelper
    {

        public static readonly string baseURL = "https://reqres.in/api/";

        public static async Task<String> GetAsync()
        {
            using(HttpClient client = new HttpClient())
            {
                using(HttpResponseMessage res = await client.GetAsync(baseURL + "users"))
                {
                    using(HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}
