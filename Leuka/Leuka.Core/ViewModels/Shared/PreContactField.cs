using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class PreContactFieldViewModel : IContentViewModel
    {
        public PreContactFieldViewModel(JoinUsPreContactPage joinUsPreContactPage)
        {
            BlockTitle = joinUsPreContactPage.Title;
            BlockDescription = joinUsPreContactPage.Description;
            FirstFieldTitle = joinUsPreContactPage.FirstFieldTitle;
            SecondFieldTitle = joinUsPreContactPage.SecondFieldTitle;
            ThirdFieldTitle = joinUsPreContactPage.ThirdFieldTitle;
            FirstFieldDescription = joinUsPreContactPage.FirstFieldDescription;
            SecondFieldDescription = joinUsPreContactPage.SecondFieldDescription;
            ThirdFieldDescription = joinUsPreContactPage.ThridFieldDescription;
            Button = new ButtonViewModel(joinUsPreContactPage.Button.FirstOrDefault());
        }

        public string BlockTitle { get; set; }

        public string BlockDescription { get; set; }

        public string FirstFieldTitle { get; set; }

        public string SecondFieldTitle { get; set; }

        public string ThirdFieldTitle { get; set; }

        public string FirstFieldDescription { get; set; }

        public string SecondFieldDescription { get; set; }

        public string ThirdFieldDescription { get; set; }
        public ButtonViewModel Button { get; set; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_Subscriptions.cshtml";
    }
}