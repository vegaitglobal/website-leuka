using Leuka.Models.Generated;
using System.Linq;

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

            if (quote.Separator != null && quote.Separator.Any())
            {
                Separator = new SeparatorViewModel(quote.Separator.FirstOrDefault());
            }
        }
        public string Name { get; }
        public string JobTitle { get; }
        public string Text { get; }
        public ImageViewModel Image { get; }
        public SeparatorViewModel Separator { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Quote.cshtml";
    }
}
