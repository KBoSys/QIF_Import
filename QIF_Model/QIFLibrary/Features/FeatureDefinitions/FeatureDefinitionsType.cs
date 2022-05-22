/*! \file FeatureDefinitionsType.cs
    \brief 
            The optional FeatureDefinitions element is a list of
            definitions of the inspection features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	//[XmlRoot(Namespace = "", IsNullable = false)]
	public class FeatureDefinitionsType
	{
		/// <summary>
		/// FeatureDefinition substitutionGroup
		/// </summary>
		[XmlElement(ElementName = "CircleFeatureDefinition", Type = typeof(CircleFeatureDefinitionType))]
		[XmlElement(ElementName = "CircularArcFeatureDefinition", Type = typeof(CircularArcFeatureDefinitionType))]
		[XmlElement(ElementName = "ConeFeatureDefinition", Type = typeof(ConeFeatureDefinitionType))]
		[XmlElement(ElementName = "ConicalSegmentFeatureDefinition", Type = typeof(ConicalSegmentFeatureDefinitionType))]
		[XmlElement(ElementName = "CylinderFeatureDefinition", Type = typeof(CylinderFeatureDefinitionType))]
		[XmlElement(ElementName = "CylindricalSegmentFeatureDefinition", Type = typeof(CylindricalSegmentFeatureDefinitionType))]
		[XmlElement(ElementName = "EdgePointFeatureDefinition", Type = typeof(EdgePointFeatureDefinitionType))]
		[XmlElement(ElementName = "EllipseFeatureDefinition", Type = typeof(EllipseFeatureDefinitionType))]
		[XmlElement(ElementName = "EllipticalArcFeatureDefinition", Type = typeof(EllipticalArcFeatureDefinitionType))]
		[XmlElement(ElementName = "ElongatedCircleFeatureDefinition", Type = typeof(ElongatedCircleFeatureDefinitionType))]
		[XmlElement(ElementName = "ExtrudedCrossSectionFeatureDefinition", Type = typeof(ExtrudedCrossSectionFeatureDefinitionType))]
		[XmlElement(ElementName = "GroupFeatureDefinition", Type = typeof(GroupFeatureDefinitionType))]
		[XmlElement(ElementName = "LineFeatureDefinition", Type = typeof(LineFeatureDefinitionType))]
		[XmlElement(ElementName = "MarkingFeatureDefinition", Type = typeof(MarkingFeatureDefinitionType))]
		[XmlElement(ElementName = "OppositeAngledLinesFeatureDefinition", Type = typeof(OppositeAngledLinesFeatureDefinitionType))]
		[XmlElement(ElementName = "OppositeAngledPlanesFeatureDefinition", Type = typeof(OppositeAngledPlanesFeatureDefinitionType))]
		[XmlElement(ElementName = "OppositeParallelLinesFeatureDefinition", Type = typeof(OppositeParallelLinesFeatureDefinitionType))]
		[XmlElement(ElementName = "OppositeParallelPlanesFeatureDefinition", Type = typeof(OppositeParallelPlanesFeatureDefinitionType))]
		[XmlElement(ElementName = "OtherCurveFeatureDefinition", Type = typeof(OtherCurveFeatureDefinitionType))]
		[XmlElement(ElementName = "OtherNonShapeFeatureDefinition", Type = typeof(OtherNonShapeFeatureDefinitionType))]
		[XmlElement(ElementName = "OtherShapeFeatureDefinition", Type = typeof(OtherShapeFeatureDefinitionType))]
		[XmlElement(ElementName = "OtherSurfaceFeatureDefinition", Type = typeof(OtherSurfaceFeatureDefinitionType))]
		[XmlElement(ElementName = "PatternFeatureCircleDefinition", Type = typeof(PatternFeatureCircleDefinitionType))]
		[XmlElement(ElementName = "PatternFeatureCircularArcDefinition", Type = typeof(PatternFeatureCircularArcDefinitionType))]
		[XmlElement(ElementName = "PatternFeatureLinearDefinition", Type = typeof(PatternFeatureLinearDefinitionType))]
		[XmlElement(ElementName = "PatternFeatureParallelogramDefinition", Type = typeof(PatternFeatureParallelogramDefinitionType))]
		[XmlElement(ElementName = "PlaneFeatureDefinition", Type = typeof(PlaneFeatureDefinitionType))]
		[XmlElement(ElementName = "PointDefinedCurveFeatureDefinition", Type = typeof(PointDefinedCurveFeatureDefinitionType))]
		[XmlElement(ElementName = "PointDefinedSurfaceFeatureDefinition", Type = typeof(PointDefinedSurfaceFeatureDefinitionType))]
		[XmlElement(ElementName = "PointFeatureDefinition", Type = typeof(PointFeatureDefinitionType))]
		[XmlElement(ElementName = "SphereFeatureDefinition", Type = typeof(SphereFeatureDefinitionType))]
		[XmlElement(ElementName = "SphericalSegmentFeatureDefinition", Type = typeof(SphericalSegmentFeatureDefinitionType))]
		[XmlElement(ElementName = "SurfaceOfRevolutionFeatureDefinition", Type = typeof(SurfaceOfRevolutionFeatureDefinitionType))]
		[XmlElement(ElementName = "ThreadedFeatureDefinition", Type = typeof(ThreadedFeatureDefinitionType))]
		[XmlElement(ElementName = "ToroidalSegmentFeatureDefinition", Type = typeof(ToroidalSegmentFeatureDefinitionType))]
		[XmlElement(ElementName = "TorusFeatureDefinition", Type = typeof(TorusFeatureDefinitionType))]
		public FeatureDefinitionBaseType[] Items { get; set; }

		/// <remarks The number of elements/>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Items.Length;
			set { }
		}
	}
}
