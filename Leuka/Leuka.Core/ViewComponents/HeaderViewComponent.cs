using Leuka.Core.ViewModels.Partials.Layout;
using Microsoft.AspNetCore.Mvc;

namespace Leuka.Core.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public HeaderViewComponent()
        {
        }
        public IViewComponentResult Invoke(HeaderViewModel viewModel)
        {
            try
            {
                if (viewModel == null) return Content(string.Empty);

                return View("/Views/Partials/Layout/_Header.cshtml", viewModel);
            }
            catch (Exception exception)
            {
                return Content(string.Empty);
            }
        }
    }
}
