using System;
using Umbraco.Web;
using Leuka.Core.Extensions;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Linq;
using System.Collections.Generic;

namespace Leuka.Core.ViewModels.Partials.Layout
{
	public class HeaderViewModel
	{
		public HeaderViewModel(IHeader header)
		{
			if (header == null) throw new ArgumentNullException(nameof(header));

			Logo = header.Logo.ToViewModel();
			LogoUrl = header.AncestorOrSelf<Home>().Url();
            NavigationLinks = header.Links.Select(link => new LinkViewModel(link));
			DonationButton = new ButtonViewModel(header.DonationButton.FirstOrDefault());
        }

		public ImageViewModel Logo { get; }
		public string LogoUrl { get; }
        public IEnumerable<LinkViewModel> NavigationLinks { get; }
		public ButtonViewModel DonationButton { get; }
    }
}
