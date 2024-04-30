namespace CoffeeShop.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public string OrderName { get; set; }

		public double OrderPrice { get; set; }

		public string? OrderUrl { get; set; }
		public int OrderCount { get; set; }
	}
}
