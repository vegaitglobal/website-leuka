using Leuka.Core.ViewModels.Shared;
using System.Collections.Generic;

namespace Leuka.Core.ViewModels.Shared
{
    public class BreadcrumbsViewModel : IContentViewModel
    {
        public BreadcrumbsViewModel()
        {
            Chain = new List<ButtonViewModel>();
        }
        public IList<ButtonViewModel> Chain { get; set; }
        public string PartialViewPath => "~/Views/Partials/NestedContent/_BreadcrumbsViewModel.cshtml";
    }
}
