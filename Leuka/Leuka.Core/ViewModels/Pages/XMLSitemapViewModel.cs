﻿using Leuka.Core.Extensions;
using Leuka.Models.DocumentTypes;
using Leuka.Models.Extensions;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Leuka.Core.ViewModels.Pages
{
    public class XMLSitemapViewModel
	{
		public XMLSitemapViewModel(IDomainRoot node)
		{
			Items = node.GetSitemapXMLItems<ISeo>().Select(p => p.ToViewModel()).ToList();
		}

		public IReadOnlyList<XMLSitemapItemViewModel> Items { get; }
	}

	public class XMLSitemapItemViewModel
	{
		public XMLSitemapItemViewModel(ISeo page)
		{
			Url = page.Url(mode: UrlMode.Absolute);
			ChangeDate = page.UpdateDate.ToUniversalTime();
			ChangeFrequency = page.SitemapChangeFrequency;
			Priority = page.SitemapPriority;
		}

		public string Url { get; }
		public DateTime ChangeDate { get; }
		public string ChangeFrequency { get; }
		public string Priority { get; }
	}
}
