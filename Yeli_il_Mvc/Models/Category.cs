using Yeli_il_Mvc.Models.Base;

namespace Yeli_il_Mvc.Models;

public class Category : BaseNameableEntity
{
	public string ImageUrl { get; set; } = null!;
	public List<Product>? Products { get; set; }
}

