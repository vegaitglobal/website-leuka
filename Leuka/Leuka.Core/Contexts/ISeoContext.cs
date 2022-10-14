using Leuka.Models.DocumentTypes;

namespace Leuka.Core.Contexts
{
	public interface ISeoContext<out T> : ISiteContext where T : class, ISeo
	{
		T Seo { get; }
	}
}
