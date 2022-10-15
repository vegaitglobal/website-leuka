using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Shared
{
    public class GalleryViewModel : IContentViewModel
    {
        public GalleryViewModel(Gallery gallery)
        {
            Images = gallery.Images.Select(x => new ImageViewModel(x));
            NumberOfImages = Images.Count();
        }

        public int NumberOfImages { get; }

        public IEnumerable<ImageViewModel> Images { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Gallery.cshtml";
    }
}
