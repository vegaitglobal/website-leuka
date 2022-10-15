using Leuka.Core.Contexts;
using Leuka.Core.ViewModels.Shared;
using Leuka.Models.Generated;
using System.Collections.Generic;
using System.Linq;

namespace Leuka.Core.ViewModels.Pages
{
	public class HomeViewModel : PageViewModel
	{
		public HomeViewModel(IPageContext<Home> context) : base(context)
		{
            Components = new List<IContentViewModel>();

            var mediumTextBlocks = context.Page.MediumText;
            if (mediumTextBlocks != null)
            {
                var mediumTextBlocksModels =  mediumTextBlocks.Select(x =>  new MediumTextBlockViewModel(x));
                Components.AddRange(mediumTextBlocksModels);
            }

            var splitBlocks = context.Page.SplitBlock;
            if (splitBlocks != null)
            {
                var splitBlocksModels = splitBlocks.Select(x => new SplitBlockViewModel(x));
                Components.AddRange(splitBlocksModels);
            }
        }

        public List<IContentViewModel> Components { get; set; }
	}
}
