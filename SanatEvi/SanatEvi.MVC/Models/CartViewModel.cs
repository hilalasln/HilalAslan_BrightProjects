using SanatEvi.Data.Concrete.EfCore.Configs;
using System.ComponentModel.DataAnnotations;

namespace SanatEvi.MVC.Models
{
    public class CartViewModel
    {
        public int CartId { get; set; }
        public List<CartItemViewModel> CartItems { get; set; }
        public decimal? TotalPrice()
        {
            return CartItems.Sum(ci=>ci.Price * ci.Quantity);
        }
    }
    public class CartItemViewModel
    {
        public int CartItemId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseUrl { get; set; }
        public string CourseImageUrl { get; set; }
        public decimal? Price { get; set; }
        [Required(ErrorMessage ="Boş bırakılmalalıdır.")]
        public int Quantity { get; set; }
    }
}
