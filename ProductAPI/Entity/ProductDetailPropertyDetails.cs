using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAPI.Entity
{
    public class ProductDetailPropertyDetails
    {
        [Key]
        public int ProductDetailPropertyDetailId { get; set; }
        public int? ProductDetailId { get; set; }
        //[ForeignKey("ProductDetailId")]
        public ProductDetail? ProductDetails { get; set; }

        public int? PropertyDetailId { get; set; }
        //[ForeignKey("PropertyDetailId")]
        public PropertyDetails? PropertyDetails { get; set; }

        public int? ProductId { get; set; }
        //[ForeignKey("ProductId")]
        public Product? Products { get; set; }
    }
}
