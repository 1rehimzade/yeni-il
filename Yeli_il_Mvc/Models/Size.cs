using Yeli_il_Mvc.Models.Base;

namespace Yeli_il_Mvc.Models;

public class Size : BaseNameableEntity
{
	public List<ProductSize>? ProductSizes { get; set; }
}
