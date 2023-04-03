using Leuka.Core.ViewModels.Pages;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.DocumentTypes;
using Leuka.Models.Generated;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Leuka.Core.Extensions
{
    public static class ViewModelExtensions
	{
		public static ImageViewModel ToViewModel(this Image image)
			=> image != null ? new ImageViewModel(image) : default(ImageViewModel);

		public static ImageViewModel ToViewModel(this IPublishedContent image)
			=> image != null ? new ImageViewModel(image as Image) : default(ImageViewModel);

		public static ImageViewModel TryCreateImageViewModel(this IPublishedContent content)
		{
			return (content as Image)?.ToViewModel();
		}

		public static XMLSitemapItemViewModel ToViewModel(this ISeo page)
			=> page != null ? new XMLSitemapItemViewModel(page) : default(XMLSitemapItemViewModel);

	}
}
