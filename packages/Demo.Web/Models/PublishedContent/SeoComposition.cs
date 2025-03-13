using EightyDays.Baseline.Models;

namespace Demo.Web.Models.PublishedContent
{
	public partial interface ISeoComposition : IPageSeo
	{
		string? IPageSeo.SeoAuthor => null;
	}
}