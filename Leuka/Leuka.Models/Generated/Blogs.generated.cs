//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.4.0+daff988
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Leuka.Models.Generated
{
	/// <summary>Blogs</summary>
	[PublishedModel("blogs")]
	public partial class Blogs : PublishedContentModel, IFooter, IHeader, IPage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		public new const string ModelTypeAlias = "blogs";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Blogs, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Blogs(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// App Promotion
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("appPromotion")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.AppPromotion> AppPromotion => this.Value<global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.AppPromotion>>(_publishedValueFallback, "appPromotion");

		///<summary>
		/// Grid
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("grid")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.BlockGrid> Grid => this.Value<global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.BlockGrid>>(_publishedValueFallback, "grid");

		///<summary>
		/// Highlighted article
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("highlightedArticle")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.HighlightedArticle> HighlightedArticle => this.Value<global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.HighlightedArticle>>(_publishedValueFallback, "highlightedArticle");

		///<summary>
		/// Page Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageHeadline")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.TitleDescriptionAndButton> PageHeadline => this.Value<global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.TitleDescriptionAndButton>>(_publishedValueFallback, "pageHeadline");

		///<summary>
		/// App Store URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("appStoreURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link AppStoreUrl => global::Leuka.Models.Generated.Footer.GetAppStoreUrl(this, _publishedValueFallback);

		///<summary>
		/// Contact Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactEmail")]
		public virtual string ContactEmail => global::Leuka.Models.Generated.Footer.GetContactEmail(this, _publishedValueFallback);

		///<summary>
		/// Copyright Text: The site copyright text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("copyrightText")]
		public virtual string CopyrightText => global::Leuka.Models.Generated.Footer.GetCopyrightText(this, _publishedValueFallback);

		///<summary>
		/// Facebook URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("facebookURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link FacebookUrl => global::Leuka.Models.Generated.Footer.GetFacebookUrl(this, _publishedValueFallback);

		///<summary>
		/// FooterLinks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> FooterLinks => global::Leuka.Models.Generated.Footer.GetFooterLinks(this, _publishedValueFallback);

		///<summary>
		/// Footer Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent FooterLogo => global::Leuka.Models.Generated.Footer.GetFooterLogo(this, _publishedValueFallback);

		///<summary>
		/// Instagram URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("instagramURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link InstagramUrl => global::Leuka.Models.Generated.Footer.GetInstagramUrl(this, _publishedValueFallback);

		///<summary>
		/// MediaLinks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mediaLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> MediaLinks => global::Leuka.Models.Generated.Footer.GetMediaLinks(this, _publishedValueFallback);

		///<summary>
		/// Play Store URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("playStoreURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link PlayStoreUrl => global::Leuka.Models.Generated.Footer.GetPlayStoreUrl(this, _publishedValueFallback);

		///<summary>
		/// Separator
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("separator")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.Separator> Separator => global::Leuka.Models.Generated.Footer.GetSeparator(this, _publishedValueFallback);

		///<summary>
		/// Twitter URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twitterURL")]
		public virtual global::Umbraco.Cms.Core.Models.Link TwitterUrl => global::Leuka.Models.Generated.Footer.GetTwitterUrl(this, _publishedValueFallback);

		///<summary>
		/// Donation Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("donationButton")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.Button> DonationButton => global::Leuka.Models.Generated.Header.GetDonationButton(this, _publishedValueFallback);

		///<summary>
		/// Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("links")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> Links => global::Leuka.Models.Generated.Header.GetLinks(this, _publishedValueFallback);

		///<summary>
		/// Logo: The site logo image.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("logo")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent Logo => global::Leuka.Models.Generated.Header.GetLogo(this, _publishedValueFallback);

		///<summary>
		/// PopupDonate
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("popupDonate")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.DonatePopup> PopupDonate => global::Leuka.Models.Generated.Header.GetPopupDonate(this, _publishedValueFallback);

		///<summary>
		/// ThanksPopup
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("thanksPopup")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Leuka.Models.Generated.ThankyouPopup> ThanksPopup => global::Leuka.Models.Generated.Header.GetThanksPopup(this, _publishedValueFallback);

		///<summary>
		/// Alternate Languages: Language codes (en-US, en-GB etc).
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("alternateLanguages")]
		public virtual global::System.Collections.Generic.IEnumerable<string> AlternateLanguages => global::Leuka.Models.Generated.Page.GetAlternateLanguages(this, _publishedValueFallback);

		///<summary>
		/// Canonical Link: The page canonical link.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("canonicalLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link CanonicalLink => global::Leuka.Models.Generated.Page.GetCanonicalLink(this, _publishedValueFallback);

		///<summary>
		/// External Redirect: Redirects to provided external URL.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("externalRedirect")]
		public virtual string ExternalRedirect => global::Leuka.Models.Generated.Page.GetExternalRedirect(this, _publishedValueFallback);

		///<summary>
		/// Hide From Search Engines: Hides page from search engines like Google, Yahoo etc.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[ImplementPropertyType("hideFromSearchEngines")]
		public virtual bool HideFromSearchEngines => global::Leuka.Models.Generated.Page.GetHideFromSearchEngines(this, _publishedValueFallback);

		///<summary>
		/// Hide From Sitemap: If selected, the node will be hidden from the sitemap.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[ImplementPropertyType("hideFromSitemap")]
		public virtual bool HideFromSitemap => global::Leuka.Models.Generated.Page.GetHideFromSitemap(this, _publishedValueFallback);

		///<summary>
		/// Hide From Site Search: Hides page from the site search.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[ImplementPropertyType("hideFromSiteSearch")]
		public virtual bool HideFromSiteSearch => global::Leuka.Models.Generated.Page.GetHideFromSiteSearch(this, _publishedValueFallback);

		///<summary>
		/// Navigation Title: If empty, page title will be used.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("navigationTitle")]
		public virtual string NavigationTitle => global::Leuka.Models.Generated.Page.GetNavigationTitle(this, _publishedValueFallback);

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphDescription")]
		public virtual string OpenGraphDescription => global::Leuka.Models.Generated.Page.GetOpenGraphDescription(this, _publishedValueFallback);

		///<summary>
		/// Image: Note: Image dimensions should be at least 1200x627 px.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphImage")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent OpenGraphImage => global::Leuka.Models.Generated.Page.GetOpenGraphImage(this, _publishedValueFallback);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphTitle")]
		public virtual string OpenGraphTitle => global::Leuka.Models.Generated.Page.GetOpenGraphTitle(this, _publishedValueFallback);

		///<summary>
		/// Page Title: The page title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::Leuka.Models.Generated.Page.GetPageTitle(this, _publishedValueFallback);

		///<summary>
		/// Seo Description: The page SEO description.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoDescription")]
		public virtual string SeoDescription => global::Leuka.Models.Generated.Page.GetSeoDescription(this, _publishedValueFallback);

		///<summary>
		/// Seo Keywords: The page SEO keywords.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoKeywords")]
		public virtual string SeoKeywords => global::Leuka.Models.Generated.Page.GetSeoKeywords(this, _publishedValueFallback);

		///<summary>
		/// Seo Title: The page SEO title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoTitle")]
		public virtual string SeoTitle => global::Leuka.Models.Generated.Page.GetSeoTitle(this, _publishedValueFallback);

		///<summary>
		/// Sitemap Change Frequency: The expected change frequency of the page, associated with the sitemap used by search engines.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sitemapChangeFrequency")]
		public virtual string SitemapChangeFrequency => global::Leuka.Models.Generated.Page.GetSitemapChangeFrequency(this, _publishedValueFallback);

		///<summary>
		/// Sitemap Priority: Priority of the page, associated with the sitemap used by search engines.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sitemapPriority")]
		public virtual string SitemapPriority => global::Leuka.Models.Generated.Page.GetSitemapPriority(this, _publishedValueFallback);

		///<summary>
		/// Hide From Site Navigation: If selected, the node will be hidden from site navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::Leuka.Models.Generated.Page.GetUmbracoNaviHide(this, _publishedValueFallback);

		///<summary>
		/// Internal Redirect: Redirects to selected Umbraco node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoRedirect")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent UmbracoRedirect => global::Leuka.Models.Generated.Page.GetUmbracoRedirect(this, _publishedValueFallback);

		///<summary>
		/// URL Alias: Alternative URLs of the node. Separate with commas.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoUrlAlias")]
		public virtual string UmbracoUrlAlias => global::Leuka.Models.Generated.Page.GetUmbracoUrlAlias(this, _publishedValueFallback);

		///<summary>
		/// URL Name: Enables overriding default URL of the node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoUrlName")]
		public virtual string UmbracoUrlName => global::Leuka.Models.Generated.Page.GetUmbracoUrlName(this, _publishedValueFallback);
	}
}
