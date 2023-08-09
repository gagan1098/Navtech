using System.ComponentModel.DataAnnotations.Schema;

namespace Navtech
{
    public class OrderProductMapping
    {
        public int id {  get; set; }

        [ForeignKey("productId")]
        public int productId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey("orderId")]
        public string orderId { get; set; }
        public virtual Order Order  { get; set; }
    }
}
