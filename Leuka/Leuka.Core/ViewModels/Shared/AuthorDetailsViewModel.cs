using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class AuthorDetailsViewModel
    {
        public AuthorDetailsViewModel(AuthorDetails authorDetails)
        {
            FullName = authorDetails.FullName;
            PublishDate = authorDetails.PublishDate.ToString("dd.MM.yyyy.");
            Description = authorDetails.Description;
            Image = new ImageViewModel(authorDetails.Image);
        }

        public string FullName { get; }
        public string PublishDate { get; }
        public string Description { get; }
        public ImageViewModel Image { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_AuthorDetailsViewModel.cshtml";

    }
}
