namespace ProductAPI.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }

        public virtual IEnumerable<ProductDetailPropertyDetails> ProductDetailPropertyDetails { get; set; }
        public virtual IEnumerable<Properties> Properties { get; set; }
    }
}
