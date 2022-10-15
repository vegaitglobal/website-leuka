using Leuka.Models.Generated;
using System;
using Umbraco.Web.Models;

namespace Leuka.Core.ViewModels.Shared
{
    public class ButtonViewModel : IContentViewModel
    {
        public ButtonViewModel(Button button)
        {
            ButtonColor = button.ButtonColor;
            ButtonStyle = button.ButtonStyle;
            Link = button.Link != null ? button.Link.Url : "";
            Text = button.LinkTitle;
            SetButonClass(button);
        }

        public ButtonViewModel(Link link)
        {
            Link = link?.Url;
            Text = link?.Name;
        }
        
        public ButtonViewModel(string text, string url)
        {
            Link = url;
            Text = text;
        }

        public string ButtonColor { get; set; }

        public string ButtonStyle { get; set; }

        public string Link { get; set; }

        public string Text { get; set; }

        public string ButtonClass { get; private set; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Button.cshtml";

        public const string RegularButtonTypeName = "Regular";

        public const string StrokedButtonTypeName = "Stroked";

        public const string LinkButtonTypeName = "Link";

        private void SetButonClass(Button button)
        {
            switch (button.ButtonStyle)
            {
                case RegularButtonTypeName:
                    ButtonClass = $"button-{button.ButtonColor.ToLower()}";
                    break;
                case StrokedButtonTypeName:
                    ButtonClass = $"button-{StrokedButtonTypeName.ToLower()}";
                    break;
                case LinkButtonTypeName:
                    ButtonClass = $"button-{LinkButtonTypeName.ToLower()}";
                    break;
                default:
                    ButtonClass = "button";
                    break;
            }
        }
    }
}
