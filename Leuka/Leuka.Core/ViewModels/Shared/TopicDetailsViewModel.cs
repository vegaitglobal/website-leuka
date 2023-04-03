using Leuka.Models.Generated;
using Microsoft.AspNetCore.Html;

namespace Leuka.Core.ViewModels.Shared
{
    public class TopicDetailsViewModel : IContentViewModel
    {
		public TopicDetailsViewModel(TopicDetails topicDetails)
		{
            TopicContent = new HtmlString(topicDetails.TopicContent.ToHtmlString());
		}
        public HtmlString TopicContent { get; }

		public string PartialViewPath => "~/Views/Partials/NestedContent/_TopicDetails.cshtml";
    }
}
