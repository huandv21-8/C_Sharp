using Food3.Adapters;
using Food3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Food3.Services
{
    class FoodDetailService
    {
        private Adapter _adapter = new Adapter();
        public async Task<ProductDetail> todaySpecial(int id)
        {

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(_adapter.ProductDetail(id));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ProductDetail>(stringContent);

            }
            return null;
        }
    }
}
