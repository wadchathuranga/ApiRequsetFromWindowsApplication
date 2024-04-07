using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiRequsetFromWindowsApplication
{
    public static class RestHelper
    {

        public static readonly string baseURL = "https://reqres.in/api";

        private static readonly HttpClient _httpClient = new HttpClient();


        // [GET] get all users
        public static async Task<string> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync(baseURL + "/users");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                if (result != null)
                {
                    //Convert the raw data (next line requires 'using Newton.Json'
                    //result = JsonConvert.DeserializeObject<EmpConnection.Rootobject>(rawResponse);

                    return result;
                }
            }

            return string.Empty;
        }

        // [GET] find user by Id
        public static async Task<string> GetUserByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync(baseURL + "/users/" + id);
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
            var inputData = new Dictionary<string, string>
            {
                { "name", name },
                { "job", job }
            };

            var body = new FormUrlEncodedContent(inputData);

            var response = await _httpClient.PostAsync(baseURL + "/users", body);
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
        public static async Task<string> UpdateUserAsync(string id, string name, string job)
        {
            var inputData = new Dictionary<string, string>
            {
                { "name", name },
                { "job", job }
            };

            var body = new FormUrlEncodedContent(inputData);

            var response = await _httpClient.PutAsync(baseURL + "/users/" + id, body);
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

        // [DELETE] delete user by Id
        public static async Task<string> DeleteUserByIdAsync(string id)
        {
            var response = await _httpClient.DeleteAsync(baseURL + "/users/" + id);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return "User delete successfull.";
            }

            return string.Empty;
        }

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
