using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestApiApp_Pers.Models;

namespace RestApiApp_Pers
{
    public static class PersProcessor
    {
        private static HttpClient client = new HttpClient();

        public static async Task<PersModel> LoadPers(int idPage = 2)
        {
            string url = $"https://rickandmortyapi.com/api/character/{idPage}";

            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                var headers = response.Headers;

                string responseString = await response.Content.ReadAsStringAsync();

                PersModel persModel = Newtonsoft.Json.JsonConvert.DeserializeObject<PersModel>(responseString);

                return persModel;
            }
        }
    }
}
