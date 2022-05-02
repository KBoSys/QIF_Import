/*! \file FeatureItemsType.cs
    \brief The FeatureItemsType defines a list of feature items.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
	/// <remarks The FeatureItemsType defines a list of feature items./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class FeatureItemsType
	{
		[XmlElement(ElementName = "CircleFeatureItem", Type = typeof(CircleFeatureItemType))]
		[XmlElement(ElementName = "CircularArcFeatureItem", Type = typeof(CircularArcFeatureItemType))]
		[XmlElement(ElementName = "ConeFeatureItem", Type = typeof(ConeFeatureItemType))]
		[XmlElement(ElementName = "ConicalSegmentFeatureItem", Type = typeof(ConicalSegmentFeatureItemType))]
		[XmlElement(ElementName = "CylinderFeatureItem", Type = typeof(CylinderFeatureItemType))]
		[XmlElement(ElementName = "CylindricalSegmentFeatureItem", Type = typeof(CylindricalSegmentFeatureItemType))]
		[XmlElement(ElementName = "EdgePointFeatureItem", Type = typeof(EdgePointFeatureItemType))]
		[XmlElement(ElementName = "EllipseFeatureItem", Type = typeof(EllipseFeatureItemType))]
		[XmlElement(ElementName = "EllipticalArcFeatureItem", Type = typeof(EllipticalArcFeatureItemType))]
		[XmlElement(ElementName = "ElongatedCircleFeatureItem", Type = typeof(ElongatedCircleFeatureItemType))]
		[XmlElement(ElementName = "ElongatedCylinderFeatureItem", Type = typeof(ElongatedCylinderFeatureItemType))]
		[XmlElement(ElementName = "ExtrudedCrossSectionFeatureItem", Type = typeof(ExtrudedCrossSectionFeatureItemType))]
		[XmlElement(ElementName = "GroupFeatureItem", Type = typeof(GroupFeatureItemType))]
		[XmlElement(ElementName = "LineFeatureItem", Type = typeof(LineFeatureItemType))]
		[XmlElement(ElementName = "MarkingFeatureItem", Type = typeof(MarkingFeatureItemType))]
		[XmlElement(ElementName = "OppositeAngledLinesFeatureItem", Type = typeof(OppositeAngledLinesFeatureItemType))]
		[XmlElement(ElementName = "OppositeAngledPlanesFeatureItem", Type = typeof(OppositeAngledPlanesFeatureItemType))]
		[XmlElement(ElementName = "OppositeParallelLinesFeatureItem", Type = typeof(OppositeParallelLinesFeatureItemType))]
		[XmlElement(ElementName = "OppositeParallelPlanesFeatureItem", Type = typeof(OppositeParallelPlanesFeatureItemType))]
		[XmlElement(ElementName = "OtherCurveFeatureItem", Type = typeof(OtherCurveFeatureItemType))]
		[XmlElement(ElementName = "OtherNonShapeFeatureItem", Type = typeof(OtherNonShapeFeatureItemType))]
		[XmlElement(ElementName = "OtherShapeFeatureItem", Type = typeof(OtherShapeFeatureItemType))]
		[XmlElement(ElementName = "OtherSurfaceFeatureItem", Type = typeof(OtherSurfaceFeatureItemType))]
		[XmlElement(ElementName = "PatternFeatureCircleItem", Type = typeof(PatternFeatureCircleItemType))]
		[XmlElement(ElementName = "PatternFeatureCircularArcItem", Type = typeof(PatternFeatureCircularArcItemType))]
		[XmlElement(ElementName = "PatternFeatureLinearItem", Type = typeof(PatternFeatureLinearItemType))]
		[XmlElement(ElementName = "PatternFeatureParallelogramItem", Type = typeof(PatternFeatureParallelogramItemType))]
		[XmlElement(ElementName = "PlaneFeatureItem", Type = typeof(PlaneFeatureItemType))]
		[XmlElement(ElementName = "PointDefinedCurveFeatureItem", Type = typeof(PointDefinedCurveFeatureItemType))]
		[XmlElement(ElementName = "PointDefinedSurfaceFeatureItem", Type = typeof(PointDefinedSurfaceFeatureItemType))]
		[XmlElement(ElementName = "PointFeatureItem", Type = typeof(PointFeatureItemType))]
		[XmlElement(ElementName = "SphereFeatureItem", Type = typeof(SphereFeatureItemType))]
		[XmlElement(ElementName = "SphericalSegmentFeatureItem", Type = typeof(SphericalSegmentFeatureItemType))]
		[XmlElement(ElementName = "SurfaceOfRevolutionFeatureItem", Type = typeof(SurfaceOfRevolutionFeatureItemType))]
		[XmlElement(ElementName = "ThreadedFeatureItem", Type = typeof(ThreadedFeatureItemType))]
		[XmlElement(ElementName = "ToroidalSegmentFeatureItem", Type = typeof(ToroidalSegmentFeatureItemType))]
		[XmlElement(ElementName = "TorusFeatureItem", Type = typeof(TorusFeatureItemType))]
		public FeatureItemBaseType[] Items { get; set; }

		/// <remarks The number of elements/>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Items.Length;
		}
	}

	public abstract class FeatureItemBaseType
	{

	}
}
