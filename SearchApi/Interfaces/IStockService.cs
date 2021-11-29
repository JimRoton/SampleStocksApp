using SearchApi.Models;

namespace SearchApi.Interfaces
{
    public interface IStockService
    {
        Stock GetStock(string symbol);
    }
}