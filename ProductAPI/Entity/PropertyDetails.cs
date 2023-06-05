using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAPI.Entity
{
    public class PropertyDetails
    {
        [Key]
        public int PropertyDetailId { get; set; }
        public int PropertyId { get; set; }
        //[ForeignKey("PropertyId")]
        public Properties? Properties { get; set; }
        public string PropertyDetailCode { get; set; }
        public string PropertyDetailName { get; set;}
        public virtual IEnumerable<ProductDetailPropertyDetails> ProductDetailPropertyDetails { get; set; }
    }
}
