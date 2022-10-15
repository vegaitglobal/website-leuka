using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Shared
{
	public class SponsorsViewModel : IContentViewModel
    {
        public SponsorsViewModel(Sponsors sponsors)
        {
            Title = sponsors.Title;
            Description = sponsors.Description;
            Images =  sponsors.SponsorsLogos.Select(x => new ImageViewModel(x));
        }
        public string Title { get; }
        public string Description { get; }
        public IEnumerable<ImageViewModel> Images { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Sponsors.cshtml";
    }
}
