using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public static readonly string baseURL = "https://reqres.in/api";


        // [GET] get all users
        public static async Task<string> GetUsersAsync()
        {
            var client = new HttpClient();

            var response = await client.GetAsync(baseURL + "/users");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                if (result != null)
                {
                    return result;
                }
            }

            return string.Empty;
        }

        // [GET] find user by Id
        public static async Task<string> GetUserByIdAsync(string id)
        {
            var client = new HttpClient();

            var response = await client.GetAsync(baseURL + "/users/" + id);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                if (result != null)
                {
                    return result;
                }

            }

            return string.Empty;
        }

        // [POST] create a user
        public static async Task<string> CreateUserAsync(string name, string job)
        {
            var client = new HttpClient();

            var inputData = new Dictionary<string, string>
            {
                { "name", name },
                { "job", job }
            };

            var body = new FormUrlEncodedContent(inputData);

            var response = await client.PostAsync(baseURL + "/users", body);
            if (response.StatusCode == HttpStatusCode.Created)
            {
                var result = await response.Content.ReadAsStringAsync();
                if (result != null)
                {
                    return result;
                }
            }

            return string.Empty;
        }

        // [PUT] update user by Id


        // [DELETE] delete user by Id


        // Common methods
        #region
        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }
        #endregion
    }
}
