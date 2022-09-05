/*! \file FeatureBaseType.cs
    \brief abstract base type for feature definitions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureDefinitions;
using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Features.FeatureMeasurement;
using QIF_Model.QIFLibrary.Features.Nominals;
using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
    /// <summary>
    /// The FeatureBaseType is the abstract base type for feature
    /// definitions, feature nominals, feature items, and feature
    /// measurements.It describes a subset of information common to all features.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonShapeFeatureMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkingFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNonShapeFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShapeFeatureMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherShapeFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecifiedFeatureMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveFeatureMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceFeatureMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonShapeFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkingFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNonShapeFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShapeFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherShapeFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecifiedFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonShapeFeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkingFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNonShapeFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShapeFeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherShapeFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecifiedFeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveFeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceFeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonShapeFeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkingFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNonShapeFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShapeFeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherShapeFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecifiedFeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveFeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceFeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class FeatureBaseType : QIFApplications.QIFIdTypeBase
    {
        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement]
        public QIFLibrary.Primitives.AttributesType Attributes { get; set; }
    }

    /// <summary>
    /// The SetFeatureType defines that a feature has a set value rather
    /// than a checked (directly measured or constructed) value. The set
    /// feature type is used in cases where a non-measurable basic value
    /// needs to be tracked by virtue of appearing on a product print, For
    /// example, a circle representing the area in which weld splatter is not allowed.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SetFeatureType
    {
    }

    /// <summary>
    /// The MeasuredFeatureType defines that a feature is measured.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class MeasuredFeatureType
    {
        /// <remarks> The optional PointList element is a list of references to nominal target measurement points for the feature.</remarks>
        public PointListType PointList { get; set; }
    }
}
