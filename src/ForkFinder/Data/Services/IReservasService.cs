using ForkFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForkFinder.Data.Services
{
    public interface IReservasService
    {
        /*Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);*/
        Task<List<Reserva>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
