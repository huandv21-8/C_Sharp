using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Service
{
    class WeatherService
    {
        private readonly string stringUrl = String.Format
            ("http://api.openweathermap.org/data/2.5/weather?q=hanoi,vn&appid=09a71427c59d38d6a34f89b47d75975c&units=metric"
            );

        public async Task<Root> GetData()
        {
            
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(stringUrl);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Root>(stringContent);
                 
            }
            return null;
        }
    }
}
