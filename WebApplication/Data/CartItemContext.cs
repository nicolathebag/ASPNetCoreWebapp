using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class CartItemContext : DbContext
    {
        public CartItemContext (DbContextOptions<CartItemContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.CartItem> CartItem { get; set; } = default!;
    }
}
