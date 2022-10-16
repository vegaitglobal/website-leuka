using System.Collections.Generic;
using System.Linq;
using System.Web;
using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Generated = Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class AboutUsViewModel  : PageViewModel
    {
        public AboutUsViewModel(IPageContext<Generated.AboutUs> context) : base(context)
        {
            ContactUsModals = context.Page.ContactUs.Select(x => new ContactusViewModel(x));
        }

        public IEnumerable<ContactusViewModel> ContactUsModals { get; }
    }
}