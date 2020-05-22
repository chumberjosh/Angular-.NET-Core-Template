using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DatingApp.API.Models.xTransportMap;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Data
{
    public class ExternalApiRepository : IExternalApiRepository
    {
        IEnumerable<ExternalApi> IExternalApiRepository.FetchData(string apiUrl, string apiKey)
        {
            string getTable = "GetData?table_name=bicoe.sv_daily_load_master";
            List<ExternalApi> list = new List<ExternalApi>();
            
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);
            var result = client.GetAsync(apiUrl + getTable).Result;

            if (result.IsSuccessStatusCode)
            {
                return list = (result.Content.ReadAsAsync<List<ExternalApi>>()).Result;
            }
            else
            {
                return null;
            }
        }
    }
}