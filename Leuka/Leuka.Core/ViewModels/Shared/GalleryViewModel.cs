using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class GalleryViewModel : IContentViewModel
    {
        public GalleryViewModel(Gallery gallery)
        {
            var images = gallery.Images.Select(x => new ImageViewModel(x)).ToList();

            GalleryRows = images.Select((s, i) => new { Value = s, Index = i })
                     .GroupBy(item => item.Index / 3, item => item.Value)
                     .Cast<IEnumerable<ImageViewModel>>()
                     .Select(x => new GalleryRowViewModel(x.ToList()))
                     .ToList();

            var separator = gallery.Separator.FirstOrDefault();

            if(separator != null)
            {
                Separator = new SeparatorViewModel(separator);
            }
        }

        public SeparatorViewModel Separator { get; }

        public List<GalleryRowViewModel> GalleryRows { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Gallery.cshtml";
    }
}
