using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Entity
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetailId { get; set; }
        public string ProductPropertyName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double SellPrice { get; set; }
        public int ParentId { get; set; }
        public virtual IEnumerable<ProductDetailPropertyDetails> ProductDetailPropertyDetails { get; set; }

    }
}
