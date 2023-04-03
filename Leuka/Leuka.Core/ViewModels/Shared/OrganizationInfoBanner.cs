using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Shared
{
    public class OrganizationInfoBannerViewModel : IContentViewModel
    {
        public OrganizationInfoBannerViewModel(OrganizationInfoBanner banner)
        {

            Title = banner.Title;
            Description = banner.Description;

            var button = banner.Button.FirstOrDefault();

            if(button != null)
            {
                Button = new ButtonViewModel(button);
            }

            var separator = banner.Separator.FirstOrDefault();

            if(separator != null)
            {
                Separator = new SeparatorViewModel(separator);
            }
        }
        public string Title { get; }

        public string Description { get; }

        public SeparatorViewModel Separator { get; }

        public ButtonViewModel Button { get; set; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_OrganizationInfoBanner.cshtml";
    }
}
