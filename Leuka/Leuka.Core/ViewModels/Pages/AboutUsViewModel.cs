using System.Collections.Generic;
using System.Web;
using Leuka.Core.Contexts;
using Leuka.Models.Generated;

namespace Leuka.Core.ViewModels.Pages
{
    public class AboutUsViewModel  : PageViewModel
    {
        public AboutUsViewModel(IPageContext<AboutUs> context) : base(context)
        {
            Title = context.Page.Title;
            Description = context.Page.Description;
            Image = context.Page.Image;
            TextList = context.Page.TextList;
            Paragraph = context.Page.RichContent;
        }
        
        public string Title { get; }
        public IHtmlString Description { get; }
        public Image Image { get; }
        public IEnumerable<string> TextList { get; }
        
        public IHtmlString Paragraph { get; }
    }
}