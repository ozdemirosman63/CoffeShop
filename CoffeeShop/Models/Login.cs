using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
     
		[Required(ErrorMessage = "Email is Required ")]
		[EmailAddress]
        public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required ")]
		public string Password { get; set; }
    }
}
