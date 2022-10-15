using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class ButtonViewModel : IContentViewModel
    {
        public ButtonViewModel(Button button)
        {
            ButtonColor = button.ButtonColor;
            ButtonStyle = button.ButtonStyle;
            Link = button.Link.Url;
            Text = button.Text;
        }
        public string ButtonColor { get; set; }

        public string ButtonStyle { get; set; }

        public string Link { get; set; }

        public string Text { get; set; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Button.cshtml";
    }
}
