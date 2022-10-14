using Examine;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Leuka.Search.Services;
using Leuka.Search.Services.Implementation;

namespace Leuka.Core.Composers
{
	public class SearchComposer : IUserComposer
	{
		public void Compose(Composition composition)
		{
			composition.RegisterFor<ISearchService, SearchService>(f => new SearchService(f.GetInstance<IExamineManager>(), f.GetInstance<IUmbracoContextAccessor>()));
		}
	}
}
