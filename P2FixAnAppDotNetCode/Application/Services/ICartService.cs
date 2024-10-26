using P2FixAnAppDotNetCode.Models;

namespace P2FixAnAppDotNetCode.Application.Services
{
    public interface ICartService
    {
        void AddItem(Product product, int quantity);

        void RemoveLine(Product product);

        void Clear();

        double GetTotalValue();

        double GetAverageValue();
    }
}