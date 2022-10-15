using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class QuoteViewModel : IContentViewModel
    {
        public QuoteViewModel(Quote quote)
        {
            Name = quote.QuotatorName;
            JobTitle = quote.JobTitle;
            Text = quote.QuoteText;
            Image = new ImageViewModel(quote.Image);
        }
        public string Name { get; }
        public string JobTitle { get; }
        public string Text { get; }
        public ImageViewModel Image { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Quote.cshtml";
    }
}
