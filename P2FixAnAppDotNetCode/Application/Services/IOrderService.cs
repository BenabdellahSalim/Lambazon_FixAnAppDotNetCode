using P2FixAnAppDotNetCode.Models;

namespace P2FixAnAppDotNetCode.Application.Services
{
    public interface IOrderService
    {
        void SaveOrder(Order order);
    }
}
