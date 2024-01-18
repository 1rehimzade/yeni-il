using Yeli_il_Mvc.Models.Base;

namespace Yeli_il_Mvc.Models
{
	public class Color : BaseNameableEntity
	{
		public List<ProductColor>? ProductColors { get; set; }
	}
}
