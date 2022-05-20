/*! \file PointFeatureNominalType.cs
    \brief The PointFeatureNominalType defines the point feature nominal information for an individual point feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
	/// <remarks The PointFeatureNominalType defines the point feature nominal information for an individual point feature./>
	public class PointFeatureNominalType : PointFeatureNominalBaseType
	{
		/// <remarks The Location element is the nominal location of the point./>
		[XmlElement]
		public Primitives.PointType Location { get; set; }

		/// <remarks The optional Normal element is the nominal unit normal vector at the point of a surface on which the point lies./>
		[XmlElement()]
		public Primitives.UnitVectorType Normal { get; set; }

		/// <remarks The optional Constructed element signifies that the point is constructed and provides details of the construction method./>
		[XmlElement()]
		public PointConstructionMethodType Constructed { get; set; }
	}

	/// <remarks The PointConstructionMethodType defines the method for constructing a unique nominal or measured point feature./>
	public class PointConstructionMethodType
	{
		#region Choice
		/// <remarks This optional compositor provides a choice of the construction method for the point feature./>
		[XmlChoiceIdentifier("Type")]
		[XmlElement(ElementName = "Intersection", Type = typeof(PointFeatureIntersectionType))]
		[XmlElement(ElementName = "Projection", Type = typeof(PointFeatureProjectionType))]
		[XmlElement(ElementName = "Copy", Type = typeof(PointFeatureCopyType))]
		[XmlElement(ElementName = "Cast", Type = typeof(PointFeatureCastType))]
		[XmlElement(ElementName = "Transform", Type = typeof(PointFeatureTransformType))]
		[XmlElement(ElementName = "FromCone", Type = typeof(PointFeatureFromConeType))]
		[XmlElement(ElementName = "FromScan", Type = typeof(PointFeatureFromScanType))]
		[XmlElement(ElementName = "CenterOfGravity", Type = typeof(PointFeatureCenterOfGravityType))]
		[XmlElement(ElementName = "Pierce", Type = typeof(PointFeaturePierceType))]
		[XmlElement(ElementName = "MidPoint", Type = typeof(PointFeatureMidPointType))]
		[XmlElement(ElementName = "MovePoint", Type = typeof(PointFeatureMovePointType))]
		[XmlElement(ElementName = "MovePointVector", Type = typeof(PointFeatureMovePointVectorType))]
		[XmlElement(ElementName = "MovePointAxis", Type = typeof(PointFeatureMovePointAxisType))]
		[XmlElement(ElementName = "Extreme", Type = typeof(PointFeatureExtremeType))]
		public ConstructionMethodBaseType Method { get; set; }

		[XmlIgnore]
		public PointConstructionMethodChoiceType Type { get; set; }
		#endregion
	}

	[XmlType(IncludeInSchema = false)]
	public enum PointConstructionMethodChoiceType
	{
		None,
		Intersection,
		Projection,
		Copy,
		Cast,
		Transform,
		FromCone,
		FromScan,
		CenterOfGravity,
		Pierce,
		MidPoint,
		MovePoint,
		MovePointVector,
		MovePointAxis,
		Extreme,
	}

	/// <remarks The PointFeatureIntersectionType defines a point that is the intersection of two features./>
	public class PointFeatureIntersectionType : ConstructionMethodBaseType
	{
		/// <remarks Each IntersectionFeature element identifies a feature that intersects the other feature at a point./>
		public IntermediatesPMI.SequencedBaseFeatureType[] IntersectionFeature { get; set; } = new IntermediatesPMI.SequencedBaseFeatureType[2];
	}

	/// <remarks The PointFeatureProjectionType defines a projected point construction with the point to be projected and the projection plane./>
	public class PointFeatureProjectionType : ConstructionMethodBaseType
	{
		/// <remarks The ProjectionPlane element identifies the plane onto which the point is to be projected./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType ProjectionPlane { get; set; }

		/// <remarks The ProjectionFeature element identifies the point-reducible feature to be projected./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType ProjectionFeature { get; set; }
	}

	/// <remarks The PointFeatureCopyType defines a copied point feature construction./>
	public class PointFeatureCopyType : ConstructionMethodBaseType
	{
		/// <remarks The BasePointFeature element identifies the point to be copied./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BasePointFeature { get; set; }
	}

	/// <remarks The PointFeatureCastType defines the cast of another feature type to a point feature.The location is copied from the base feature./>
	public class PointFeatureCastType : ConstructionMethodBaseType
	{
		/// <remarks The BaseFeature element identifies the base feature to be cast to a point feature./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseFeature { get; set; }
	}

	/// <remarks The PointFeatureTransformType defines a point feature construction
	/// by the transformation of a point feature through the specified nominal or actual coordinate system./>
	public class PointFeatureTransformType : ConstructionMethodBaseType
	{
		/// <remarks The BasePointFeature element identifies the point feature to be transformed./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BasePointFeature { get; set; }

		/// <remarks The Transformation element identifies the coordinate system to be used to transform the point feature./>
		[XmlElement]
		public TransformationReferenceType Transformation { get; set; }
	}

	/// <remarks The PointFeatureFromConeType defines the construction of a point which is the vertex of a cone./>
	public class PointFeatureFromConeType : ConstructionMethodBaseType
	{
		/// <remarks The BaseCone element identifies a cone from which the vertex point will be extracted./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseCone { get; set; }
	}

	/// <remarks The PointFeatureFromScanType defines a point feature construction
	/// by the retrieval of a point feature from a scanned surface feature (point cloud)./>
	public class PointFeatureFromScanType : ConstructionMethodBaseType
	{
		/// <remarks The SurfaceFeature element identifies the scanned surface feature from which the point feature is retrieved./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType SurfaceFeature { get; set; }

		/// <remarks The SearchRadius element is the radius around the nominal feature, wherein the measured feature can be expected.The
		/// SearchRadius is the radius of a cylinder.All scanned points within this cylinder are examined for the retrieval
		/// of the feature.The cylinder's axis is defined by the feature's normal direction and the cylinder's axis passes
		/// through the feature's location point./>
		[XmlElement]
		public Units.LinearValueType SearchRadius { get; set; }

		/// <remarks The RetrievalMethod element defines the method for extracting the point feature from the points within the acceptance cylinder./>
		[XmlElement]
		public IntermediatesPMI.RetrievalMethodEnumType RetrievalMethod { get; set; }
	}

	/// <remarks The PointFeatureCenterOfGravityType defines the construction of a point which is the center of gravity of the base feature locations./>
	public class PointFeatureCenterOfGravityType : ConstructionMethodBaseType
	{
		/// <remarks Each BaseFeature element identifies a base feature whose location is taken as one of the set for computation of the center of gravity./>
		[XmlElement(ElementName = "BaseFeature", Type = typeof(IntermediatesPMI.BaseFeatureType))]
		public IntermediatesPMI.BaseFeatureType[] BaseFeatures { get; set; }

		/// <remarks The required n attribute is the number of employees in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.BaseFeatures.Length;
			set { }
		}
	}

	/// <remarks The PointFeaturePierceType defines the construction of a point	created by the intersection of a surface with a line or curve./>
	public class PointFeaturePierceType : ConstructionMethodBaseType
	{
		/// <remarks The SurfaceFeature element identifies a feature representing a surface such as a plane, cylinder, point-defined surface, etc./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType SurfaceFeature { get; set; }

		/// <remarks The CurveFeature element identifies a feature representing a curve such as a line, cylinder axis, point-defined curve, etc./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType CurveFeature { get; set; }
	}

	/// <remarks The PointFeatureMidPointType defines the construction of a point which is the midpoint of two base feature locations./>
	public class PointFeatureMidPointType : ConstructionMethodBaseType
	{
		/// <remarks Each BaseFeature element identifies a base feature whose location will be used to compute a midpoint./>
		[XmlElement]
		public IntermediatesPMI.SequencedBaseFeatureType[] BaseFeature { get; set; } = new IntermediatesPMI.SequencedBaseFeatureType[2];
	}

	/// <remarks The PointFeatureMovePointType defines the construction of a point by translating a base point by a specified offset./>
	public class PointFeatureMovePointType : ConstructionMethodBaseType
	{
		/// <remarks The BaseFeature element identifies the feature that defines the base point that is to be translated./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseFeature { get; set; }

		/// <remarks The Offset element specifies the XYZ amount by which the
		/// base point is to be translated in the current coordinate system./>
		[XmlElement]
		public Primitives.VectorType Offset { get; set; }

		/// <remarks The DirectionalOffset element specifies the offset distance and direction by which the base point is to be
		/// translated in the current coordinate system./>
		[XmlElement]
		public IntermediatesPMI.DirectionalOffsetType DirectionalOffset { get; set; }
	}

	/// <remarks The PointFeatureMovePointVectorType defines the construction of a
	/// point by translating a base point a specified distance in a
	/// specified direction.If the Distance is negative, the point moves
	/// in the opposite direction to the vector./>
	public class PointFeatureMovePointVectorType : ConstructionMethodBaseType
	{
		/// <remarks The BaseFeature element identifies the point to be translated./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseFeature { get; set; }

		/// <remarks The Distance element is the distance by which the base point is to be translated./>
		[XmlElement]
		public Units.LinearValueType Distance { get; set; }

		/// <remarks The Vector element is the unit vector specifying the translation direction./>
		[XmlElement]
		public Primitives.UnitVectorType Vector { get; set; }
	}

	/// <remarks The PointFeatureMovePointAxisType defines the construction of a
	/// point by translating a point by a specified distance along a
	/// feature axis from another feature location.If the Distance is
	/// negative, the point moves in the opposite direction to the feature axis./>
	public class PointFeatureMovePointAxisType : ConstructionMethodBaseType
	{
		/// <remarks The BaseFeature element identifies the point to be translated./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseFeature { get; set; }

		/// <remarks The Distance element is the distance by which the base point is to be translated./>
		[XmlElement]
		public Units.LinearValueType Distance { get; set; }

		/// <remarks The BaseAxisFeature element identifies the feature whose axis defines the translation direction./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseAxisFeature { get; set; }
	}

	/// <remarks The PointFeatureExtremeType defines the construction of the extreme
	/// point on a feature in the specified direction.Except in the case
	/// of Radial, the point is the point at which a plane approaching the
	/// feature from the given direction first touches the feature./>
	public class PointFeatureExtremeType : ConstructionMethodBaseType
	{
		/// <remarks The BaseFeature element identifies the feature whose extreme location is to be used in a construction./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseFeature { get; set; }

		/// <remarks The Minimum element specifies whether the minimum or the
		/// maximum extreme of the base feature is to be used.It is
		/// set to "false" for the maximum extreme point in the
		/// specified direction, or set to "true" for the minimum./>
		[XmlElement]
		public bool Minimum { get; set; }

		#region Choice
		[XmlChoiceIdentifier("DirectionType")]
		[XmlElement("BaseAxisFeature", typeof(IntermediatesPMI.BaseFeatureType))]
		[XmlElement("Vector", typeof(Primitives.UnitVectorType))]
		[XmlElement("Xaxis", typeof(string))]
		[XmlElement("Yaxis", typeof(string))]
		[XmlElement("Zaxis", typeof(string))]
		public object Direction { get; set; }

		// Don't serialize this field. The EnumType field
		// contains the enumeration value that corresponds
		// to the MyChoice field value.
		[XmlIgnore]
		public ExtremeDirectionChoiceType DirectionType {get; set;}
		#endregion
	}

	[XmlType(IncludeInSchema = false)]
	public enum ExtremeDirectionChoiceType
	{
		None,
		BaseAxisFeature,
		Vector,
		Radial,
		Xaxis,
		Yaxis,
		Zaxis,
	}
}
