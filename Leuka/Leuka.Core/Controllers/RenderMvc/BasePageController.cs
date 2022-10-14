using Umbraco.Web.Mvc;
using Leuka.Core.Contexts;
using Leuka.Core.Extensions;
using Leuka.Models.Generated;

namespace Leuka.Core.Controllers.RenderMvc
{
	public abstract class BasePageController<T> : RenderMvcController where T : class, IPage
	{
		protected IPageContext<T> CreatePageContext(T page) => Umbraco.CreatePageContext(page);
	}
}
