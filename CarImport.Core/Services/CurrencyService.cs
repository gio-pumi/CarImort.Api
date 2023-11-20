using CarImport.Core.Interfaces;
using CarImport.Infrastructure.Helpers;
using Newtonsoft.Json;

namespace CarImport.Core.Services
{
    public class CurrencyService : ICurrencyService
    {
        public async Task<Currency> GetCurrencies()
        {
            using HttpClient client = new();

            client.BaseAddress = new Uri("https://api.freecurrencyapi.com/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("v1/latest?apikey=fca_live_rJ1in8tM5Ql0A7gepgSXKZUL1UDL5GaPhCDajCHp");

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<Currency>(await response.Content.ReadAsStringAsync());

            return new();

        }
    }
}
