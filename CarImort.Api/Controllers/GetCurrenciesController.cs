using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace CarImort.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCurrenciesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrencies()
        {
            try
            {
                HttpClient client = new HttpClient();
                
                client.BaseAddress = new Uri("https://api.freecurrencyapi.com/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("v1/latest?apikey=fca_live_rJ1in8tM5Ql0A7gepgSXKZUL1UDL5GaPhCDajCHp").Result;

                if (response.IsSuccessStatusCode)
                {
                    return Ok(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    return BadRequest("Some thing went wrong in the request");
                }
            }
            catch (Exception ex) {
                return Ok(ex.Message); }
            finally { }
        }
    }
}
