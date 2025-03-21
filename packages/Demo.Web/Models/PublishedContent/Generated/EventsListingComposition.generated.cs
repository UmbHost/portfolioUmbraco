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
	// Mixin Content Type with alias "eventsListingComposition"
	/// <summary>Events Listing Composition</summary>
	public partial interface IEventsListingComposition : IPublishedContent, IListingComposition
	{
		/// <summary>End Date</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		global::System.DateTime EndDate { get; }

		/// <summary>Listing Categories</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<string> ListingCategories { get; }

		/// <summary>Start Date</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		global::System.DateTime StartDate { get; }
	}

	/// <summary>Events Listing Composition</summary>
	[PublishedModel("eventsListingComposition")]
	public partial class EventsListingComposition : PublishedContentModel, IEventsListingComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		public new const string ModelTypeAlias = "eventsListingComposition";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<EventsListingComposition, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public EventsListingComposition(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// End Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[ImplementPropertyType("endDate")]
		public virtual global::System.DateTime EndDate => GetEndDate(this, _publishedValueFallback);

		/// <summary>Static getter for End Date</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		public static global::System.DateTime GetEndDate(IEventsListingComposition that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.DateTime>(publishedValueFallback, "endDate");

		///<summary>
		/// Listing Categories
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("listingCategories")]
		public virtual global::System.Collections.Generic.IEnumerable<string> ListingCategories => GetListingCategories(this, _publishedValueFallback);

		/// <summary>Static getter for Listing Categories</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<string> GetListingCategories(IEventsListingComposition that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<string>>(publishedValueFallback, "listingCategories");

		///<summary>
		/// Start Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[ImplementPropertyType("startDate")]
		public virtual global::System.DateTime StartDate => GetStartDate(this, _publishedValueFallback);

		/// <summary>Static getter for Start Date</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		public static global::System.DateTime GetStartDate(IEventsListingComposition that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.DateTime>(publishedValueFallback, "startDate");

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
	}
}
