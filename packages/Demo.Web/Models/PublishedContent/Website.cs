using EightyDays.Baseline.Models;
using Umbraco.Extensions;

namespace Demo.Web.Models.PublishedContent
{
	public partial class Website : ISiteSettings
	{
		public string DefaultEmail => null;

		string ISiteSettings.SiteLogo => SiteLogo?.Url();

		string ISiteSettings.SiteFavicon => SiteFavicon?.Url();
	}
}