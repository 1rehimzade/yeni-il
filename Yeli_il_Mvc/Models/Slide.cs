using Yeli_il_Mvc.Models.Base;

namespace Yeli_il_Mvc.Models;

public class Slide : BaseEntity
{
	public string Title { get; set; } = null!;
	public string? Description { get; set; }
	public string ImageUrl { get; set; } = null!;
	public string ButtonTitle { get; set; } = "Shop Now";
	public int Order { get; set; }
	public bool IsActive { get; set; }
}