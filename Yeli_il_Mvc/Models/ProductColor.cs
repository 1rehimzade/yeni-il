using Yeli_il_Mvc.Models.Base;

namespace Yeli_il_Mvc.Models;

public class ProductColor : BaseEntity
{
	public int ColorId { get; set; }
	public int ProductId { get; set; }
	public Color Color { get; set; }
	public Product Product { get; set; }
}