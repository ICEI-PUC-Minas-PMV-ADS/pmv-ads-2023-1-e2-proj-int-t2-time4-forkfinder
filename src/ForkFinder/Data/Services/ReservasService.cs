using ForkFinder.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForkFinder.Models;

namespace ForkFinder.Data.Services
{
    public class ReservasService /*: IReservasService*/
    {
        private readonly AppDbContext _context;
        public ReservasService(AppDbContext context)
        {
            _context = context;
        }

        /*public async Task<List<Reserva>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            var reservas = await _context.Reservas.Include(n => n.Mesa).Include(n => n.User).ToListAsync();

            if (userRole != "Admin")
            {
                reservas = reservas.Where(n => n.UserId == userId).ToList();
            }

            return reservas;
        }*/
/*
        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    MovieId = item.Movie.Id,
                    OrderId = order.Id,
                    Price = item.Movie.Price
                };
                await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }*/
    }
}
