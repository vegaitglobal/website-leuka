﻿using Leuka.Models.Generated;

namespace Leuka.Core.Contexts
{
	public interface IPageContext<out T> : ISiteContext where T : class, IPage
	{
		T Page { get; }
	}
}
