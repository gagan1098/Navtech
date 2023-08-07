using System.Net.Mail;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Navtech
{
    public class Validations
    {
        public static bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string number)
        {
           string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            return Regex.IsMatch(number, motif);


        }

        public static bool IsValidOrderStatus(string status)
        {
            return Enum.IsDefined(typeof(OrderStatus), status);
        }

        public static bool IsValidProductId(int productId , DataContextProduct _context)
        {
            var query = (from product in _context.products where product.productId == productId select product).ToList();
            if (query.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            

        }




    }
}
