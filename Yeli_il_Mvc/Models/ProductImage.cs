using Yeli_il_Mvc.Models.Base;

namespace Yeli_il_Mvc.Models;

public class ProductImage : BaseEntity
{
	public string Url { get; set; }
	public bool? IsPrimary { get; set; }
	public int ProductId { get; set; }
	public Product Product { get; set; }
}
