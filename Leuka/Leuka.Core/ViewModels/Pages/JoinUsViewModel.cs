using System.Collections.Generic;
using System.Linq;
using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class JoinUsViewModel : PageViewModel
    {
        public JoinUsViewModel(IPageContext<JoinUs> context)
            : base(context)
        {
            Components = new List<IContentViewModel>();

            IEnumerable<Gallery> gallery = context.Page.Gallery;

            if (gallery == null)
            {
                return;
            }

            IEnumerable<GalleryViewModel> galleryModels = gallery.Select(x => new GalleryViewModel(x));
            Components.AddRange(galleryModels);
        }

        public List<IContentViewModel> Components { get; set; }
    }
}