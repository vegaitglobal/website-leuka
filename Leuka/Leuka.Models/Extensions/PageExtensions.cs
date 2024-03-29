﻿using Leuka.Models.Generated;

namespace Leuka.Models.Extensions
{
	public static class PageExtensions
	{
		public static string PageTitle(this IPage page)
		{
			return page.GetPropertyWithDefaultValue(page.Name);
		}

		public static bool IsHome(this IPage page)
		{
			//return page.ContentType.Alias == Home.ModelTypeAlias;
			return true;
		}
	}
}
