/*! \file CircleFeatureNominalType.cs
    \brief The CircleFeatureNominalType defines nominal information for an individual circle feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
	/// <remarks The CircleFeatureNominalType defines nominal information for an individual circle feature./>
	public class CircleFeatureNominalType : CurveFeatureNominalBaseType
	{
		/// <remarks The Location element is the nominal center point of the circle./>
		[XmlElement]
		public Primitives.PointType Location { get; set; }

		/// <remarks The Normal element is the nominal unit normal vector of the plane of the circle./>
		[XmlElement]
		public Primitives.UnitVectorType Normal { get; set; }

		/// <remarks The optional Sweep element gives the nominal start direction and the swept angle for a partial circle.
		/// The StartVector of the Sweep must lie in the plane of the circle./>
		[XmlElement(IsNullable = true)]
		public Primitives.SweepType Sweep { get; set; }

		/// <remarks The optional Constructed element signifies that the circle is constructed and provides details of the construction method./>
		[XmlElement(IsNullable = true)]
		public CircleConstructionMethodType Constructed { get; set; }
	}

	/// <remarks The CircleConstructionMethodType defines the method for constructing a unique nominal or measured circle feature. />
	public class CircleConstructionMethodType
	{
		#region Choice
		/// <remarks This optional compositor provides a choice of the construction method for the circle./>
		[XmlChoiceIdentifier("Type")]
		[XmlElement(ElementName = "BestFit", Type = typeof(CircleBestFitType), IsNullable = true)]
		[XmlElement(ElementName = "Recompensated", Type = typeof(CircleRecompType), IsNullable = true)]
		[XmlElement(ElementName = "Intersection", Type = typeof(CircleIntersectionType), IsNullable = true)]
		[XmlElement(ElementName = "Projection", Type = typeof(CircleProjectionType), IsNullable = true)]
		[XmlElement(ElementName = "Copy", Type = typeof(CircleCopyType), IsNullable = true)]
		[XmlElement(ElementName = "Cast", Type = typeof(CircleCastType), IsNullable = true)]
		[XmlElement(ElementName = "Tangent", Type = typeof(CircleTangentType), IsNullable = true)]
		[XmlElement(ElementName = "TangentThrough", Type = typeof(CircleTangentThroughType), IsNullable = true)]
		[XmlElement(ElementName = "Transform", Type = typeof(CircleTransformType), IsNullable = true)]
		[XmlElement(ElementName = "FromCone", Type = typeof(CircleFromConeType), IsNullable = true)]
		[XmlElement(ElementName = "FromScan", Type = typeof(CircleFromScanType), IsNullable = true)]
		public ConstructionMethodBaseType Method { get; set; }

		[XmlType(IncludeInSchema = false)]
		public enum CircleConstructionMethodChoiceType
		{
			None,
			BestFit,
			Recompensated,
			Intersection,
			Projection,
			Copy,
			Cast,
			Tangent,
			TangentThrough,
			Transform,
			FromCone,
			FromScan,
		}

		[XmlIgnore]
		public CircleConstructionMethodChoiceType Type { get; set; }
		#endregion
	}

	/// <remarks TODO/>
	public class CircleBestFitType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleRecompType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleIntersectionType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleProjectionType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleCopyType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleCastType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleTangentType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleTangentThroughType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleTransformType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleFromConeType : ConstructionMethodBaseType
	{

	}

	/// <remarks TODO/>
	public class CircleFromScanType : ConstructionMethodBaseType
	{

	}
}
