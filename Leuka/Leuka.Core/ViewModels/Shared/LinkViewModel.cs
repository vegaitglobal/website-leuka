﻿using Leuka.Models.Generated;
using Umbraco.Cms.Core.Models;

namespace Leuka.Core.ViewModels.Shared
{
    public class LinkViewModel
	{
		public LinkViewModel(string url, string content, string target = null)
		{
			Url = url;
			Content = content;
			Target = target;
		}

		public LinkViewModel(Link link) : this(link?.Url, link?.Name, link?.Target)
		{ }

		public LinkViewModel(IPage node, string target = null) : this(node.Url(), node.PageTitle, target)
		{ }

		public string Url { get; }
		public string Content { get; }
		public string Target { get; }
	}
}
