using Yeli_il_Mvc.Models.Base;

namespace Yeli_il_Mvc.Models;

public class Setting : BaseEntity
{
	public string Key { get; set; }
	public string Value { get; set; }
}
