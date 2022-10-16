using System.Linq;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class MediumTextBlockViewModel : IContentViewModel
    {
        public MediumTextBlockViewModel(MediumTextBlock mediumTextBlock)
        {
            Text = mediumTextBlock.Text;

            if (mediumTextBlock.Separator != null && mediumTextBlock.Separator.Any())
            {
                Separator = new SeparatorViewModel(mediumTextBlock.Separator.FirstOrDefault());
            }
        }

        public string Text { get; }

        public SeparatorViewModel Separator { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_MediumTextBlock.cshtml";
    }
}