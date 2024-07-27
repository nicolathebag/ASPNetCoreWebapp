using System.Globalization;

namespace WebApplication1.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Type Type { get; set; }

        public decimal Rating { get; set; }

        public int Quantity { get; set; }
    }
}
