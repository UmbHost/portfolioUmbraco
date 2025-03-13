//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.4.0+6e3a691
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Demo.Web.Models.PublishedContent
{
	/// <summary>Careers Detail Page</summary>
	[PublishedModel("careersDetailPage")]
	public partial class CareersDetailPage : PublishedContentModel, IBodyClassComposition, ICareersListingComposition, IContentComposition, IOpenGraphComposition, IRedirectComposition, ISeoComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		public new const string ModelTypeAlias = "careersDetailPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<CareersDetailPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public CareersDetailPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Body Class
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bodyClass")]
		public virtual string BodyClass => global::Demo.Web.Models.PublishedContent.BodyClassComposition.GetBodyClass(this, _publishedValueFallback);

		///<summary>
		/// Listing Categories
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("listingCategories")]
		public virtual global::System.Collections.Generic.IEnumerable<string> ListingCategories => global::Demo.Web.Models.PublishedContent.CareersListingComposition.GetListingCategories(this, _publishedValueFallback);

		///<summary>
		/// Listing Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[ImplementPropertyType("listingDate")]
		public virtual global::System.DateTime ListingDate => global::Demo.Web.Models.PublishedContent.CareersListingComposition.GetListingDate(this, _publishedValueFallback);

		///<summary>
		/// Body Elements
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bodyElements")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel BodyElements => global::Demo.Web.Models.PublishedContent.ContentComposition.GetBodyElements(this, _publishedValueFallback);

		///<summary>
		/// Listing Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("listingHeading")]
		public virtual string ListingHeading => global::Demo.Web.Models.PublishedContent.ListingComposition.GetListingHeading(this, _publishedValueFallback);

		///<summary>
		/// Listing Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("listingImages")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> ListingImages => global::Demo.Web.Models.PublishedContent.ListingComposition.GetListingImages(this, _publishedValueFallback);

		///<summary>
		/// Listing Link Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("listingLinkText")]
		public virtual string ListingLinkText => global::Demo.Web.Models.PublishedContent.ListingComposition.GetListingLinkText(this, _publishedValueFallback);

		///<summary>
		/// Listing Summary
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("listingSummary")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ListingSummary => global::Demo.Web.Models.PublishedContent.ListingComposition.GetListingSummary(this, _publishedValueFallback);

		///<summary>
		/// Open Graph Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphDescription")]
		public virtual string OpenGraphDescription => global::Demo.Web.Models.PublishedContent.OpenGraphComposition.GetOpenGraphDescription(this, _publishedValueFallback);

		///<summary>
		/// Open Graph Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OpenGraphImage => global::Demo.Web.Models.PublishedContent.OpenGraphComposition.GetOpenGraphImage(this, _publishedValueFallback);

		///<summary>
		/// Open Graph Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphTitle")]
		public virtual string OpenGraphTitle => global::Demo.Web.Models.PublishedContent.OpenGraphComposition.GetOpenGraphTitle(this, _publishedValueFallback);

		///<summary>
		/// Internal Redirect
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("internalRedirect")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent InternalRedirect => global::Demo.Web.Models.PublishedContent.RedirectComposition.GetInternalRedirect(this, _publishedValueFallback);

		///<summary>
		/// Canonical URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("canonicalUrl")]
		public virtual string CanonicalUrl => global::Demo.Web.Models.PublishedContent.SeoComposition.GetCanonicalUrl(this, _publishedValueFallback);

		///<summary>
		/// Robots Options
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("robotsOptions")]
		public virtual global::System.Collections.Generic.IEnumerable<string> RobotsOptions => global::Demo.Web.Models.PublishedContent.SeoComposition.GetRobotsOptions(this, _publishedValueFallback);

		///<summary>
		/// SEO Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoDescription")]
		public virtual string SeoDescription => global::Demo.Web.Models.PublishedContent.SeoComposition.GetSeoDescription(this, _publishedValueFallback);

		///<summary>
		/// SEO Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoTitle")]
		public virtual string SeoTitle => global::Demo.Web.Models.PublishedContent.SeoComposition.GetSeoTitle(this, _publishedValueFallback);
	}
}
