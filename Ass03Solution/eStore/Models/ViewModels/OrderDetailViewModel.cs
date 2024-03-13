namespace eStore.Models.ViewModels
{
	public class OrderDetailViewModel
	{
		public int ProductId { get; set; }
		public decimal? UnitPrice { get; set; }
		public int? Quantity { get; set; }
		public decimal? Discount { get; set; }
	}
}
