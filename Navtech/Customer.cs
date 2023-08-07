using System.ComponentModel.DataAnnotations;

namespace Navtech
{
    public class Customer
    {
        [System.Text.Json.Serialization.JsonIgnore] public int customerId { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string mobileNumber { get; set; }

        public string address { get; set; }

        public string email { get; set; }

        public DateTime timeCreated { get; set; }
 


    }
}
