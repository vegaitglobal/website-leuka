using Umbraco.Web;
using Umbraco.Web.Models;
using Leuka.Models.Generated;
using System.Web;

namespace Leuka.Core.ViewModels.Shared
{
	public class TopicDetailsViewModel : IContentViewModel
    {
		public TopicDetailsViewModel(TopicDetails topicDetails)
		{
            TopicContent = topicDetails.TopicContent;
		}
        public IHtmlString TopicContent { get; }

		public string PartialViewPath => "~/Views/Partials/NestedContent/_TopicDetails.cshtml";
    }
}
