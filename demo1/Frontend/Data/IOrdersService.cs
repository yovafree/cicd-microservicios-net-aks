using System;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Data
{
    public interface IOrdersService
    {
        Task<OrderDto> GetOrderAsync(string OrderUuid);
    }
}