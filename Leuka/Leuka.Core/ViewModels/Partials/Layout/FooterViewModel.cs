using Leuka.Core.Extensions;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Partials.Layout
{
	public class FooterViewModel
	{
		public FooterViewModel(IFooter footer)
		{
			if (footer == null) throw new ArgumentNullException(nameof(footer));

			CopyrightText = footer.CopyrightText;
            ContactEmail = footer.ContactEmail;
			AppStore = new ButtonViewModel(footer.AppStoreUrl);
            PlayStore = new ButtonViewModel(footer.AppStoreUrl);
            Facebook = new ButtonViewModel(footer.FacebookUrl);
            Twitter = new ButtonViewModel(footer.TwitterUrl);
            Instagram = new ButtonViewModel(footer.InstagramUrl); 
			Logo = footer.FooterLogo.ToViewModel();
            NavigationLinks = footer.FooterLinks.Select(link => new LinkViewModel(link));
            MediaLinks = footer.MediaLinks.Select(link => new LinkViewModel(link));
        }

		public string CopyrightText { get; }
		public string ContactEmail { get; }
		public ButtonViewModel AppStore { get; }
		public ButtonViewModel PlayStore { get; }
		public ButtonViewModel Facebook { get; }
		public ButtonViewModel Twitter { get; }
		public ButtonViewModel Instagram { get; }
        public ImageViewModel Logo { get; }
        public IEnumerable<LinkViewModel> NavigationLinks { get; }
        public IEnumerable<LinkViewModel> MediaLinks { get; }
    }
}
