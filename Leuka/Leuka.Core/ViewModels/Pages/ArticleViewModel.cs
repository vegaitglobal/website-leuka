using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Pages
{
    public class ArticleViewModel : PageViewModel
    {
        public ArticleViewModel(IPageContext<Article> context) : base(context)
        {

            var topicDetails = context.Page.TopicDetails;
            if (topicDetails != null)
            {
                TopicDetailsModel = topicDetails.Select(x => new TopicDetailsViewModel(x)).FirstOrDefault();
            }
        }

        public TopicDetailsViewModel TopicDetailsModel { get; }
    }
}
