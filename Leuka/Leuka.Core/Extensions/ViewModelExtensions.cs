using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Leuka.Core.ViewModels.Pages;
using Leuka.Core.ViewModels.Partials.Listing;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.DocumentTypes;
using Leuka.Models.Generated;
using Leuka.Search.Models;

namespace Leuka.Core.Extensions
{
	public static class ViewModelExtensions
	{
		public static ImageViewModel ToViewModel(this Image image)
			=> image != null ? new ImageViewModel(image) : default(ImageViewModel);

		public static ImageViewModel TryCreateImageViewModel(this IPublishedContent content)
		{
			return (content as Image)?.ToViewModel();
		}

		public static XMLSitemapItemViewModel ToViewModel(this ISeo page)
			=> page != null ? new XMLSitemapItemViewModel(page) : default(XMLSitemapItemViewModel);

		public static SearchResultsItemViewModel ToViewModel(this ISearchResultItem item)
			=> new SearchResultsItemViewModel(item);

		public static IEnumerable<SearchResultsItemViewModel> ToViewModel(this IEnumerable<ISearchResultItem> items)
		{
			if (items == null) return Enumerable.Empty<SearchResultsItemViewModel>();

			return items.Select(ToViewModel);
		}
	}
}
