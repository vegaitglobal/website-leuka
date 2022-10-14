using Leuka.Models.Generated;

namespace Leuka.Core.Contexts
{
	public interface ISiteContext
	{
		IPage CurrentPage { get; }
		Home Home { get; }
		ISiteSettings SiteSettings { get; }
	}
}
