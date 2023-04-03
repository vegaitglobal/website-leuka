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
	// Mixin Content Type with alias "siteSettings"
	/// <summary>Site Settings</summary>
	public partial interface ISiteSettings : IPublishedContent
	{
		/// <summary>Canonical Domain</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string CanonicalDomain { get; }

		/// <summary>Cookie Script</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string CookieScript { get; }

		/// <summary>Google Analytics Script Code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string GoogleAnalyticsScriptCode { get; }

		/// <summary>Google Tag Manager Non-Script Code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string GoogleTagManagerNonScriptCode { get; }

		/// <summary>Google Tag Manager Script Code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string GoogleTagManagerScriptCode { get; }

		/// <summary>Hide All Pages From Search Engines</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		bool HideAllPagesFromSearchEngines { get; }

		/// <summary>Port</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Port { get; }

		/// <summary>Receiver Email Address</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string ReceiverEmailAddress { get; }

		/// <summary>Robots</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Robots { get; }

		/// <summary>Sender Email Address</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SenderEmailAddress { get; }

		/// <summary>Sender Email Password</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SenderEmailPassword { get; }

		/// <summary>Server Address</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string ServerAddress { get; }

		/// <summary>Site Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SiteName { get; }
	}

	/// <summary>Site Settings</summary>
	[PublishedModel("siteSettings")]
	public partial class SiteSettings : PublishedContentModel, ISiteSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		public new const string ModelTypeAlias = "siteSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<SiteSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SiteSettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Canonical Domain: The site canonical domain.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("canonicalDomain")]
		public virtual string CanonicalDomain => GetCanonicalDomain(this, _publishedValueFallback);

		/// <summary>Static getter for Canonical Domain</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetCanonicalDomain(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "canonicalDomain");

		///<summary>
		/// Cookie Script
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cookieScript")]
		public virtual string CookieScript => GetCookieScript(this, _publishedValueFallback);

		/// <summary>Static getter for Cookie Script</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetCookieScript(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "cookieScript");

		///<summary>
		/// Google Analytics Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleAnalyticsScriptCode")]
		public virtual string GoogleAnalyticsScriptCode => GetGoogleAnalyticsScriptCode(this, _publishedValueFallback);

		/// <summary>Static getter for Google Analytics Script Code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetGoogleAnalyticsScriptCode(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "googleAnalyticsScriptCode");

		///<summary>
		/// Google Tag Manager Non-Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleTagManagerNonScriptCode")]
		public virtual string GoogleTagManagerNonScriptCode => GetGoogleTagManagerNonScriptCode(this, _publishedValueFallback);

		/// <summary>Static getter for Google Tag Manager Non-Script Code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetGoogleTagManagerNonScriptCode(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "googleTagManagerNonScriptCode");

		///<summary>
		/// Google Tag Manager Script Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleTagManagerScriptCode")]
		public virtual string GoogleTagManagerScriptCode => GetGoogleTagManagerScriptCode(this, _publishedValueFallback);

		/// <summary>Static getter for Google Tag Manager Script Code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetGoogleTagManagerScriptCode(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "googleTagManagerScriptCode");

		///<summary>
		/// Hide All Pages From Search Engines: This will create robots meta tag with "noindex,nofollow" value. Note: this should be unchecked on the live site.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[ImplementPropertyType("hideAllPagesFromSearchEngines")]
		public virtual bool HideAllPagesFromSearchEngines => GetHideAllPagesFromSearchEngines(this, _publishedValueFallback);

		/// <summary>Static getter for Hide All Pages From Search Engines</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		public static bool GetHideAllPagesFromSearchEngines(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "hideAllPagesFromSearchEngines");

		///<summary>
		/// Port
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("port")]
		public virtual string Port => GetPort(this, _publishedValueFallback);

		/// <summary>Static getter for Port</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetPort(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "port");

		///<summary>
		/// Receiver Email Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("receiverEmailAddress")]
		public virtual string ReceiverEmailAddress => GetReceiverEmailAddress(this, _publishedValueFallback);

		/// <summary>Static getter for Receiver Email Address</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetReceiverEmailAddress(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "receiverEmailAddress");

		///<summary>
		/// Robots: Content that will be served when Robots.txt is requested.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("robots")]
		public virtual string Robots => GetRobots(this, _publishedValueFallback);

		/// <summary>Static getter for Robots</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetRobots(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "robots");

		///<summary>
		/// Sender Email Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("senderEmailAddress")]
		public virtual string SenderEmailAddress => GetSenderEmailAddress(this, _publishedValueFallback);

		/// <summary>Static getter for Sender Email Address</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSenderEmailAddress(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "senderEmailAddress");

		///<summary>
		/// Sender Email Password
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("senderEmailPassword")]
		public virtual string SenderEmailPassword => GetSenderEmailPassword(this, _publishedValueFallback);

		/// <summary>Static getter for Sender Email Password</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSenderEmailPassword(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "senderEmailPassword");

		///<summary>
		/// Server Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serverAddress")]
		public virtual string ServerAddress => GetServerAddress(this, _publishedValueFallback);

		/// <summary>Static getter for Server Address</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetServerAddress(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "serverAddress");

		///<summary>
		/// Site Name: The site name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteName")]
		public virtual string SiteName => GetSiteName(this, _publishedValueFallback);

		/// <summary>Static getter for Site Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSiteName(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "siteName");
	}
}
