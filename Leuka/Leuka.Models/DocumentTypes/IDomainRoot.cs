using Umbraco.Core.Models.PublishedContent;

namespace Leuka.Models.DocumentTypes
{
	/// <summary>
	///	Marks document type model class that Site domain will be associated with.
	/// </summary>
	public interface IDomainRoot : IPublishedContent
	{
	}
}
