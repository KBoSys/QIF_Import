/*! \file FeatureDefinitionsType.cs
    \brief 
            The optional FeatureDefinitions element is a list of
            definitions of the inspection features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
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
        [System.Xml.Serialization.XmlElementAttribute("CircularArcFeatureDefinition", typeof(CircularArcFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("CircleFeatureDefinition", typeof(CircleFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ConeFeatureDefinition", typeof(ConeFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicalSegmentFeatureDefinition", typeof(ConicalSegmentFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("CylinderFeatureDefinition", typeof(CylinderFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricalSegmentFeatureDefinition", typeof(CylindricalSegmentFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("EdgePointFeatureDefinition", typeof(EdgePointFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipseFeatureDefinition", typeof(EllipseFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipticalArcFeatureDefinition", typeof(EllipticalArcFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ElongatedCylinderFeatureDefinition", typeof(ElongatedCylinderFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ElongatedCircleFeatureDefinition", typeof(ElongatedCircleFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ExtrudedCrossSectionFeatureDefinition", typeof(ExtrudedCrossSectionFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("GroupFeatureDefinition", typeof(GroupFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("LineFeatureDefinition", typeof(LineFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("MarkingFeatureDefinition", typeof(MarkingFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OppositeParallelLinesFeatureDefinition", typeof(OppositeParallelLinesFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OppositeAngledLinesFeatureDefinition", typeof(OppositeAngledLinesFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OppositeParallelPlanesFeatureDefinition", typeof(OppositeParallelPlanesFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OppositeAngledPlanesFeatureDefinition", typeof(OppositeAngledPlanesFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCurveFeatureDefinition", typeof(OtherCurveFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherNonShapeFeatureDefinition", typeof(OtherNonShapeFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherShapeFeatureDefinition", typeof(OtherShapeFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherSurfaceFeatureDefinition", typeof(OtherSurfaceFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("PlaneFeatureDefinition", typeof(PlaneFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("PointDefinedCurveFeatureDefinition", typeof(PointDefinedCurveFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("PointDefinedSurfaceFeatureDefinition", typeof(PointDefinedSurfaceFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("PointFeatureDefinition", typeof(PointFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SphereFeatureDefinition", typeof(SphereFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalSegmentFeatureDefinition", typeof(SphericalSegmentFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceOfRevolutionFeatureDefinition", typeof(SurfaceOfRevolutionFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadedFeatureDefinition", typeof(ThreadedFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ToroidalSegmentFeatureDefinition", typeof(ToroidalSegmentFeatureDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("TorusFeatureDefinition", typeof(TorusFeatureDefinitionType))]
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
