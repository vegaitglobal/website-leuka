using Leuka.Models.Generated;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Leuka.Core.ViewModels.Shared
{
    public class ImageViewModel
	{
		public ImageViewModel(string url, string urlAbsolute, string type, 
			int width, int height, string alternateText = null)
		{
			Url = url;
			UrlAbsolute = urlAbsolute;
			Type = type;
			Width = width;
			Height = height;
			AlternateText = alternateText;
		}

		public ImageViewModel(Image image) 
			: this(image.Url(), image.MediaUrl(mode: UrlMode.Absolute), image.ContentType.Alias,
                  image.Value<int>("umbracoWidth"), image.Value<int>("umbracoHeight"),
				  string.IsNullOrWhiteSpace(image.AlternateText) ? image.Name : image.AlternateText)
		{ }

		public ImageViewModel(IPublishedContent publishedContent) 
			: this(publishedContent as Image)
		{}

		public ImageViewModel(MediaWithCrops mediaWithCrops)
			: this(mediaWithCrops.Url(), mediaWithCrops.MediaUrl(mode: UrlMode.Absolute), mediaWithCrops.ContentType.Alias,
				  mediaWithCrops.Value<int>("umbracoWidth"), mediaWithCrops.Value<int>("umbracoHeight"), null)
		{
			
		}

		public string Url { get; }
		public string UrlAbsolute { get; }
		public string Type { get; }
		public int Width { get; }
		public int Height { get; }
		public string AlternateText { get; }
	}
}
