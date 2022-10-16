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
            Facebook = new LinkViewModel(authorDetails.FacebookUrl);
            Twitter = new LinkViewModel(authorDetails.TwitterUrl);
            WhatsApp = authorDetails.WhatsAppInfo;
            Google = new LinkViewModel(authorDetails.GoogleUrl);
        }

        public string FullName { get; }
        public string PublishDate { get; }
        public string Description { get; }
        public string WhatsApp { get; }
        public ImageViewModel Image { get; }
        public LinkViewModel Facebook { get; }
        public LinkViewModel Twitter { get; }
        public LinkViewModel Google { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_AuthorDetailsViewModel.cshtml";

    }
}
