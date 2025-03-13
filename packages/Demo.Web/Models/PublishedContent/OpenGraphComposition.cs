using EightyDays.Baseline.Models;
using Umbraco.Extensions;

namespace Demo.Web.Models.PublishedContent
{
	public partial interface IOpenGraphComposition : IPageOpenGraph
	{
		string? IPageOpenGraph.OpenGraphImage => OpenGraphImage?.Url();
	}
}