using Leuka.Models.Generated;
using static Leuka.Core.Constants;

namespace Leuka.Core.ViewModels.Shared
{
    public class BlogSignUpViewModel : IContentViewModel
    {
        public BlogSignUpViewModel(BlogSignUp blogSignUp)
        {
            BlogSignUpFormClass = blogSignUp.BackgroundColor == Colors.White
                ? "bg-white"
                : string.Empty;
        }

        public string BlogSignUpFormClass { get; }
      
        public string PartialViewPath => "~/Views/Partials/NestedContent/_BlogSignUp.cshtml";
    }
}
