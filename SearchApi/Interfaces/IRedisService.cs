using SearchApi.Models;

namespace SearchApi.Interfaces
{
    public interface IRedisService : IStockService
    {
        bool HasStock(string symbol);

        void AddStock(Stock stock);
    }
}