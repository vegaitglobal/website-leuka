using System;
using Leuka.Core.Models;

namespace Leuka.Core.ViewModels.Partials.Listing
{
	public class PaginationViewModel
	{
		public PaginationViewModel(IPagination pagination)
		{
			Pagination = pagination ?? throw new ArgumentNullException(nameof(pagination));
		}

		public IPagination Pagination { get; }
	}
}
