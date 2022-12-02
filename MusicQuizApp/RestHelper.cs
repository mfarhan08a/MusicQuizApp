using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MusicQuizApp
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://itunes.apple.com/search?";
        public static async Task<string> GetAll(String music)
        {
            using (HttpClient client = new HttpClient())
            {                
                using (HttpResponseMessage response = await client.GetAsync(baseURL + $"term={music}&entity=musicTrack&limit=200"))
                //using (HttpResponseMessage response = await client.GetAsync(baseURL + "media=music"))
                //using (HttpResponseMessage response = await client.GetAsync("https://itunes.apple.com/search?term=YOASOBI&country=jp&entity=musicTrack"))
                {
                    using (HttpContent content = response.Content)
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

        public static string BeautifyJson (string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }
    }
}
