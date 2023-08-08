using System.ComponentModel.DataAnnotations;

namespace Navtech
{
    public class Order
    {
        [System.Text.Json.Serialization.JsonIgnore] public int orderId { get; set; }

        public string orderStatus { get; set; }

        public DateTime placedTime { get; set; }

        public DateTime updatedTime { get; set; }

        public int items { get; set; }        
    }
}
