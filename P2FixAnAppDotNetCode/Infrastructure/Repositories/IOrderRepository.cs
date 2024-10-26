using P2FixAnAppDotNetCode.Models;

namespace P2FixAnAppDotNetCode.Infrastructure.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
