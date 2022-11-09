using Leuka.Models.Generated;
using System.Linq;

namespace Leuka.Core.ViewModels.Shared
{
    public class HowToParticipateViewModel : IContentViewModel
    {
        public HowToParticipateViewModel(HowToHelpParticipate howToHelpParticipate)
        {
            MainTitle = howToHelpParticipate.MainTitle;
            MainDescription = howToHelpParticipate.MainDescription;
            SubTitle = howToHelpParticipate.SubTitle;
            SubDescription = howToHelpParticipate.SubDescription;
            CheckboxText1 = howToHelpParticipate.CheckboxText1;
            CheckboxText2 = howToHelpParticipate.CheckboxText2;
            CheckboxText3 = howToHelpParticipate.CheckboxText3;
            CheckboxText4 = howToHelpParticipate.CheckboxText4;
            CheckboxText5 = howToHelpParticipate.CheckboxText5;
            CheckboxText6 = howToHelpParticipate.CheckboxText6;

            var button = howToHelpParticipate.Button.FirstOrDefault();

            Button = button != null ? new ButtonViewModel(button) : new ButtonViewModel(string.Empty, string.Empty);
        }

        public string MainTitle { get; }

        public string MainDescription { get; }

        public string SubTitle { get; }

        public string SubDescription { get; }

        public string CheckboxText1 { get; }

        public string CheckboxText2 { get; }

        public string CheckboxText3 { get; }

        public string CheckboxText4 { get; }

        public string CheckboxText5 { get; }

        public string CheckboxText6 { get; }
        public ButtonViewModel Button { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_HowToParticipate.cshtml";
    }
}