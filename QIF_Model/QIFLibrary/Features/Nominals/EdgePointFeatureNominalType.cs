/*! \file EdgePointFeatureNominalType.cs
    \brief The EdgePointFeatureNominalType defines the edge-point feature
        nominal information for an individual edge-point feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
	/// <remarks The EdgePointFeatureNominalType defines the edge-point feature	nominal information for an individual edge-point feature./>
	public class EdgePointFeatureNominalType : PointFeatureNominalBaseType
	{
		/// <remarks The Location element is the nominal location of a point on the edge between two surfaces./>
		[XmlElement]
		public Primitives.PointType Location { get; set; }

		/// <remarks The Normal element is the nominal unit normal vector of the edge surface./>
		[XmlElement]
		public Primitives.UnitVectorType Normal { get; set; }

		/// <remarks The optional AdjacentNormal element is the nominal unit normal vector of the surface adjacent to the edge surface./>
		[XmlElement(IsNullable =true)]
		public Primitives.UnitVectorType AdjacentNormal { get; set; }

		/// <remarks The optional Constructed element signifies that the edge
		/// point is constructed and provides details of the construction method./>
		[XmlElement(IsNullable = true)]
		public EdgePointConstructionMethodType Constructed { get; set; }
	}

	/// <remarks The EdgePointCopyType defines a copied edge-point construction./>
	public class EdgePointCopyType : ConstructionMethodBaseType
	{
		/// <remarks The BaseEdgePoint element identifies the edge-point to be copied./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseEdgePoint { get; set; }
	}

	/// <remarks The EdgePointCastType defines an edge-point construction by the
	/// casting of another feature type to an edge-point.The location is copied from the base feature./>
	public class EdgePointCastType : ConstructionMethodBaseType
	{
		/// <remarks The BaseFeature element identifies the base feature to be cast to an edge-point./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseFeature { get; set; }
	}

	/// <remarks The EdgePointTransformType defines an edge-point construction by
	/// the transformation of an edge-point through the specified nominal
	/// or actual coordinate system./>
	public class EdgePointTransformType : ConstructionMethodBaseType
	{
		/// <remarks The BaseEdgePoint element identifies the edge-point to be transformed./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType BaseEdgePoint { get; set; }

		/// <remarks The Transformation element identifies the coordinate system to be used to transform the base edge-point./>
		[XmlElement]
		public TransformationReferenceType Transformation { get; set; }
	}

	/// <remarks The EdgePointFromScanType defines an edge-point construction by the
	/// retrieval of an edge-point from a scanned surface feature(point	cloud)./>
	public class EdgePointFromScanType : ConstructionMethodBaseType
	{
		/// <remarks The SurfaceFeature element identifies the scanned surface feature from which the edge-point is retrieved./>
		[XmlElement]
		public IntermediatesPMI.BaseFeatureType SurfaceFeature { get; set; }

		/// <remarks The SearchRadius element is the radius around the nominal feature(adjusted for depth), wherein the measured feature
		/// can be expected.The SearchRadius is the radius of a cylinder.All scanned points within this cylinder are
		/// examined for the retrieval of the feature.The cylinder's axis is defined by the feature's normal and the cylinder's
		/// axis passes through the feature's location point adjusted by the Depth element./>
		[XmlElement]
		public Units.LinearValueType SearchRadius { get; set; }

		/// <remarks The PatchRadius element is the radius around the edge-point reference used to adjust location and orientation./>
		[XmlElement]
		public Units.LinearValueType PatchRadius { get; set; }

		/// <remarks The Distance element is the distance from the surface's edge where measurements to adjust orientation and location are taken./>
		[XmlElement]
		public Units.LinearValueType Distance { get; set; }

		/// <remarks The Depth element is the measuring depth at which the edge point is to be retrieved./>
		[XmlElement]
		public Units.LinearValueType Depth { get; set; }

		/// <remarks The RetrievalMethod element is the method used for retrieving the edge point from the acceptance cylinder./>
		[XmlElement]
		public IntermediatesPMI.RetrievalMethodEnumType RetrievalMethod { get; set; }
	}

	/// <remarks The EdgePointConstructionMethodType defines the method for	constructing a unique nominal or measured edge-point feature./>
	public class EdgePointConstructionMethodType
	{
		#region Choice
		/// <remarks This optional compositor provides a choice of the construction method for the edge point./>
		[XmlChoiceIdentifier("Type")]
		[XmlElement(ElementName = "Copy", Type = typeof(EdgePointCopyType), IsNullable = true)]
		[XmlElement(ElementName = "Cast", Type = typeof(EdgePointCastType), IsNullable = true)]
		[XmlElement(ElementName = "Transform", Type = typeof(EdgePointTransformType), IsNullable = true)]
		[XmlElement(ElementName = "FromScan", Type = typeof(EdgePointFromScanType), IsNullable = true)]
		public ConstructionMethodBaseType Method { get; set;}

		[XmlIgnore]
		public EdgePointConstructionMethodChoiceType Type { get; set; }
		#endregion
	}

	[XmlType(IncludeInSchema = false)]
	public enum EdgePointConstructionMethodChoiceType
	{
		None,
		Copy,
		Cast,
		Transform,
		FromScan,
	}
}
