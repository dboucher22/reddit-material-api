using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace reddit_material_api.Controllers
{
    [Route("api/[controller]")]
    public class TempController : Controller
    {
        [HttpGet]
        public string Get()
        {
            // var client = new HttpClient() { BaseAddress = new Uri("https://www.reddit.com/api/") };
            // client.DefaultRequestHeaders.Accept.Add(
            //     new MediaTypeWithQualityHeaderValue("application/json"));
            // var byteArray = new UTF8Encoding().GetBytes("Knobby2678:YRevdmyKdbYciKvdTd00EL553uI");
            // client.DefaultRequestHeaders.Authorization =
            //     new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            // var response = client.GetAsync("v1/me").Result;
            // var result = response.Content.ReadAsStringAsync().Result;
            // return result;
            return string.Empty;
        }
    }
}
