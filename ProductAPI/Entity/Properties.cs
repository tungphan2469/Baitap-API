using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAPI.Entity
{
    public class Properties
    {
        [Key]
        public int PropertyId { get; set; }
        public int ProductId { get; set; }
        //[ForeignKey("ProductId")]
        public Product? Products { get; set; }
        public string PropertyName { get; set; }

        public string PropertySort { get; set; }
    }
}
