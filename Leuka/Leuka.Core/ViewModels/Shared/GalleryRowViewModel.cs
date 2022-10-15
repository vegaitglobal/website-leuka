using System.Collections.Generic;

namespace Leuka.Core.ViewModels.Shared
{
    public class GalleryRowViewModel : IContentViewModel
    {
        public GalleryRowViewModel(List<ImageViewModel> images)
        {
            Images = images;
        }

        public List<ImageViewModel> Images { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_GalleryRow.cshtml";
    }
}
