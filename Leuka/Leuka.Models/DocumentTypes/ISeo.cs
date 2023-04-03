using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Leuka.Models.DocumentTypes
{
    public interface ISeo : IPublishedContent
	{
		string SeoTitle { get; }
		string SeoDescription { get; }
		string SeoKeywords { get; }
		bool HideFromSearchEngines { get; }
		string SitemapChangeFrequency { get; }
		string SitemapPriority { get; }
		IEnumerable<string> AlternateLanguages { get; }
		Link CanonicalLink { get; }
	}
}
