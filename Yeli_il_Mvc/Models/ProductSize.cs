using System.Drawing;
using Yeli_il_Mvc.Models.Base;

namespace Yeli_il_Mvc.Models;

public class ProductSize : BaseEntity
{
	public int ProductId { get; set; }
	public Product Product { get; set; }
	public int SizeId { get; set; }
	public Size Size { get; set; }
}
