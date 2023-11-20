using CarImport.Infrastructure.Helpers;

namespace CarImport.Core.Interfaces
{
    public interface ICurrencyService
    {
        Task<Currency> GetCurrencies();
    }
}
