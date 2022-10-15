using Leuka.Models.Generated;
using System.Collections.Generic;

namespace Leuka.Core.ViewModels.Shared
{
	public class SeparatorViewModel : IContentViewModel
    {
		public SeparatorViewModel(Separator separator)
		{
			if (Variants.TryGetValue(separator.Variant, out var separatorClass))
            {
                SeparatorClass = separatorClass;

            }
		}
		public string SeparatorClass { get; }

		public string PartialViewPath => "~/Views/Partials/NestedContent/_Separator.cshtml";

		private readonly Dictionary<string, string> Variants = new Dictionary<string, string>
		{
			{ "Red and Blue",  "curved-line-pink"},
			{ "White and Red",  "curved-line-orange"},
		};
	}
}
