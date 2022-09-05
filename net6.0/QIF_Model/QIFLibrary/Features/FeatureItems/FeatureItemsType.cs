/*! \file FeatureItemsType.cs
    \brief The FeatureItemsType defines a list of feature items.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The FeatureItemsType defines a list of feature items.</remarks>
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

        /// <remarks> The number of elements</remarks>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.Items.Length;
            set { }
        }
    }

    /// <remarks> The FeatureItemBaseType is the abstract base type for feature
    /// items.A feature item represents a single feature with optional nominal data.</remarks>
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
    public abstract class FeatureItemBaseType : FeatureBaseType
    {
        /// <remarks> The FeatureNominalId element is the QIF id of the shape feature nominal.</remarks>
        [XmlElement]
        public Primitives.QIFReferenceFullType? FeatureNominalId { get; set; }

        /// <remarks> The optional ParentFeatureItemId element is the QIF id of
        /// the parent feature item when this feature item is derived from another shape feature item.</remarks>
        [XmlElement]
        public Primitives.QIFReferenceFullType? ParentFeatureItemId { get; set; }

        /// <remarks> The FeatureName element is the name of the feature, e.g. CIRC1, PLANE_3.</remarks>
        [XmlElement]
        public string? FeatureName { get; set; }

        /// <remarks> The optional UUID element is a persistent identifier for
        /// the shape feature item.If used, it should be generated using a widely accepted UUID generator.</remarks>
        [XmlElement]
        public Primitives.QPIdType? UUID { get; set; }

        /// <remarks> The optional NotableEventIds element is a list of the QIF
        /// ids of notable events associated with the measurement of this feature.</remarks>
        [XmlElement]
        public Primitives.ArrayReferenceType? NotableEventIds { get; set; }

        /// <remarks> The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which the feature is checked or set.</remarks>
        [XmlElement]
        public Primitives.QIFReferenceFullType? CoordinateSystemId { get; set; }
    }

    /// <remarks> The ShapeFeatureItemBaseType is the abstract base type for shape
    /// feature items.A shape feature item represents a single shape feature with optional nominal data.</remarks>
    public abstract class ShapeFeatureItemBaseType : FeatureItemBaseType
    {
        /// <remarks> The optional PointList element is a list of references to
        /// nominal target measurement points for the feature.This list overrides the list on the shape feature nominal.</remarks>
        [XmlElement]
        public PointListType? PointList { get; set; }

        /// <remarks> The optional SubstituteFeatureAlgorithm element is the
        /// substitute feature data fitting algorithm for the shape
        /// feature.This setting overrides any substitute feature algorithm defined on the feature nominal.</remarks>
        [XmlElement]
        public IntermediatesPMI.SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }

        /// <remarks> The optional VirtualMeasurement element represents a
        /// virtual measurement of the feature item.Knowing the id of
        /// the VirtualMeasurement enables finding the feature item with which the VirtualMeasurement is associated.</remarks>
        [XmlElement]
        public IntermediatesPMI.VirtualMeasurementType VirtualMeasurement { get; set; }
    }

    /// <remarks> The CurveFeatureItemBaseType is the abstract base type for	shape feature items for features composed of curves.</remarks>
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
    public abstract class CurveFeatureItemBaseType : ShapeFeatureItemBaseType
    {
    }

    /// <remarks> The NonShapeFeatureItemBaseType is the abstract base type for
    /// non-shape feature items.A non-shape feature item represents a
    /// single non-shape feature with optional nominal data.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkingFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNonShapeFeatureItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class NonShapeFeatureItemBaseType : FeatureItemBaseType
    {
    }
}
