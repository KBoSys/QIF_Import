/*! \file FeatureNominalsType.cs
    \brief defines a list of nominal definitions of inspection features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
	/// <remarks The FeatureNominalsType defines a list of nominal definitions of inspection features./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class FeatureNominalsType
	{
		/// <remarks Each FeatureNominal element gives information about the nominal definition of a unique inspection feature./>
		//[XmlElement(ElementName = "CircleFeatureNominal", Type = typeof(CircleFeatureNominalType))]
		//[XmlElement(ElementName = "CircularArcFeatureNominal", Type = typeof(CircularArcFeatureNominalType))]
		//[XmlElement(ElementName = "ConeFeatureNominal", Type = typeof(ConeFeatureNominalType))]
		//[XmlElement(ElementName = "ConicalSegmentFeatureNominal", Type = typeof(ConicalSegmentFeatureNominalType))]
		//[XmlElement(ElementName = "CylinderFeatureNominal", Type = typeof(CylinderFeatureNominalType))]
		//[XmlElement(ElementName = "CylinderFeatureNominal", Type = typeof(CylinderFeatureNominalType))]
		//[XmlElement(ElementName = "CylindricalSegmentFeatureNominal", Type = typeof(CylindricalSegmentFeatureNominalType))]
		//[XmlElement(ElementName = "CylindricalSegmentFeatureNominal", Type = typeof(CylindricalSegmentFeatureNominalType))]
		//[XmlElement(ElementName = "EdgePointFeatureNominal", Type = typeof(EdgePointFeatureNominalType))]
		//[XmlElement(ElementName = "EllipseFeatureNominal", Type = typeof(EllipseFeatureNominalType))]
		//[XmlElement(ElementName = "EdgePointFeatureNominal", Type = typeof(EdgePointFeatureNominalType))]
		//[XmlElement(ElementName = "EllipseFeatureNominal", Type = typeof(EllipseFeatureNominalType))]
		//[XmlElement(ElementName = "EllipticalArcFeatureNominal", Type = typeof(EllipticalArcFeatureNominalType))]
		//[XmlElement(ElementName = "ElongatedCircleFeatureNominal", Type = typeof(ElongatedCircleFeatureNominalType))]
		//[XmlElement(ElementName = "ElongatedCylinderFeatureNominal", Type = typeof(ElongatedCylinderFeatureNominalType))]
		//[XmlElement(ElementName = "ExtrudedCrossSectionFeatureNominal", Type = typeof(ExtrudedCrossSectionFeatureNominalType))]
		//[XmlElement(ElementName = "GroupFeatureNominal", Type = typeof(GroupFeatureNominalType))]
		//[XmlElement(ElementName = "LineFeatureNominal", Type = typeof(LineFeatureNominalType))]
		//[XmlElement(ElementName = "MarkingFeatureNominal", Type = typeof(MarkingFeatureNominalType))]
		//[XmlElement(ElementName = "OppositeAngledLinesFeatureNominal", Type = typeof(OppositeAngledLinesFeatureNominalType))]
		//[XmlElement(ElementName = "OppositeAngledPlanesFeatureNominal", Type = typeof(OppositeAngledPlanesFeatureNominalType))]
		//[XmlElement(ElementName = "OppositeParallelLinesFeatureNominal", Type = typeof(OppositeParallelLinesFeatureNominalType))]
		//[XmlElement(ElementName = "OppositeParallelPlanesFeatureNominal", Type = typeof(OppositeParallelPlanesFeatureNominalType))]
		//[XmlElement(ElementName = "OtherCurveFeatureNominal", Type = typeof(OtherCurveFeatureNominalType))]
		//[XmlElement(ElementName = "OtherNonShapeFeatureNominal", Type = typeof(OtherNonShapeFeatureNominalType))]
		//[XmlElement(ElementName = "OtherShapeFeatureNominal", Type = typeof(OtherShapeFeatureNominalType))]
		//[XmlElement(ElementName = "OtherSurfaceFeatureNominal", Type = typeof(OtherSurfaceFeatureNominalType))]
		//[XmlElement(ElementName = "PatternFeatureCircleNominal", Type = typeof(PatternFeatureCircleNominalType))]
		//[XmlElement(ElementName = "PatternFeatureCircularArcNominal", Type = typeof(PatternFeatureCircularArcNominalType))]
		//[XmlElement(ElementName = "PatternFeatureLinearNominal", Type = typeof(PatternFeatureLinearNominalType))]
		//[XmlElement(ElementName = "PatternFeatureParallelogramNominal", Type = typeof(PatternFeatureParallelogramNominalType))]
		//[XmlElement(ElementName = "PlaneFeatureNominal", Type = typeof(PlaneFeatureNominalType))]
		//[XmlElement(ElementName = "PointDefinedCurveFeatureNominal", Type = typeof(PointDefinedCurveFeatureNominalType))]
		//[XmlElement(ElementName = "PointDefinedSurfaceFeatureNominal", Type = typeof(PointDefinedSurfaceFeatureNominalType))]
		//[XmlElement(ElementName = "PointFeatureNominal", Type = typeof(PointFeatureNominalType))]
		//[XmlElement(ElementName = "SphereFeatureNominal", Type = typeof(SphereFeatureNominalType))]
		//[XmlElement(ElementName = "SphericalSegmentFeatureNominal", Type = typeof(SphericalSegmentFeatureNominalType))]
		//[XmlElement(ElementName = "SurfaceOfRevolutionFeatureNominal", Type = typeof(SurfaceOfRevolutionFeatureNominalType))]
		//[XmlElement(ElementName = "ThreadedFeatureNominal", Type = typeof(ThreadedFeatureNominalType))]
		//[XmlElement(ElementName = "ToroidalSegmentFeatureNominal", Type = typeof(ToroidalSegmentFeatureNominalType))]
		//[XmlElement(ElementName = "TorusFeatureNominal", Type = typeof(TorusFeatureNominal))]
		public FeatureNominalBaseType[] Nominals { get; set; }

		/// <remarks The required n attribute is the number of feature nominals in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Nominals.Length;
		}
	}
}
