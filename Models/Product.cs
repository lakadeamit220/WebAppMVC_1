using System.ComponentModel.DataAnnotations;

namespace WebAppMVC_1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
