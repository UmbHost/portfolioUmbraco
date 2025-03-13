using System.Collections.Generic;
using Our.Umbraco.Extensions.Theming;
using Our.Umbraco.Extensions.Theming.Models;
using Our.Umbraco.Extensions.Variables.Models;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Demo.Web
{
	public class Composer : IComposer
	{
		public void Compose(IUmbracoBuilder builder)
		{
			builder.AddTheme<StyleOne>();

			builder.AddTheme<StyleTwo>();
		}
	}

	public class StyleOne : IThemeDefinition
	{
		public string Name => "Style One";

		public string Alias => "style1";

		public string Thumbnail => null;

		public string[] Scripts =>
		[
			"/assets/js/priority*.js",
			"/assets/js/main*.js"
		];

		public string[] Styles =>
		[
            "/assets/css/priority*.css",
            "/assets/css/main*.css",
            "/assets/css/variables*.css"
        ];

		public IDictionary<string, object> Config => new Dictionary<string, object>
		{
			{
				"variables", new VariableOption[]
				{
					new()
					{
						Name = "--heading-size",
						Type = VariableType.Size,
						Group = "Default",
						IsRequired = true
					},
					new()
					{
						Name = "--heading-color",
						Type = VariableType.Color,
						DefaultValue = "#000",
						Group = "Default"
					},
					new()
					{
						Name = "--column-count",
						Type = VariableType.Number,
						Group = "Optional"
					}
				}
			}
		};
	}

	public class StyleTwo : IThemeDefinition
	{
		public string Name => "Style Two";

		public string Alias => "style2";

		public string Thumbnail => null;

		public string[] Scripts => [];

		public string[] Styles => [];

		public IDictionary<string, object> Config => null;
	}
}