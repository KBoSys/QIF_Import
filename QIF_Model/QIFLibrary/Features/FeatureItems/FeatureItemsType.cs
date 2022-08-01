/*! \file FeatureItemsType.cs
    \brief The FeatureItemsType defines a list of feature items.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
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
            set { }
        }
    }

    /// <remarks The FeatureItemBaseType is the abstract base type for feature
    /// items.A feature item represents a single feature with optional nominal data./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class FeatureItemBaseType : FeatureBaseType
    {
        /// <remarks The FeatureNominalId element is the QIF id of the shape feature nominal./>
        [XmlElement]
        public Primitives.QIFReferenceFullType FeatureNominalId { get; set; }

        /// <remarks The optional ParentFeatureItemId element is the QIF id of
        /// the parent feature item when this feature item is derived from another shape feature item./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType ParentFeatureItemId { get; set; }

        /// <remarks The FeatureName element is the name of the feature, e.g. CIRC1, PLANE_3./>
        [XmlElement()]
        public string FeatureName { get; set; }

        /// <remarks The optional UUID element is a persistent identifier for
        /// the shape feature item.If used, it should be generated using a widely accepted UUID generator./>
        [XmlElement()]
        public Primitives.QPIdType UUID { get; set; }

        /// <remarks The optional NotableEventIds element is a list of the QIF
        /// ids of notable events associated with the measurement of this feature./>
        [XmlElement()]
        public Primitives.ArrayReferenceType NotableEventIds { get; set; }

        /// <remarks The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which the feature is checked or set./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType CoordinateSystemId { get; set; }
    }

    /// <remarks The ShapeFeatureItemBaseType is the abstract base type for shape
    /// feature items.A shape feature item represents a single shape feature with optional nominal data./>
    public abstract class ShapeFeatureItemBaseType : FeatureItemBaseType
    {
        /// <remarks The optional PointList element is a list of references to
        /// nominal target measurement points for the feature.This list overrides the list on the shape feature nominal./>
        [XmlElement()]
        public PointListType PointList { get; set; }

        /// <remarks The optional SubstituteFeatureAlgorithm element is the
        /// substitute feature data fitting algorithm for the shape
        /// feature.This setting overrides any substitute feature algorithm defined on the feature nominal./>
        [XmlElement()]
        public IntermediatesPMI.SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }

        /// <remarks The optional VirtualMeasurement element represents a
        /// virtual measurement of the feature item.Knowing the id of
        /// the VirtualMeasurement enables finding the feature item with which the VirtualMeasurement is associated./>
        [XmlElement()]
        public IntermediatesPMI.VirtualMeasurementType VirtualMeasurement { get; set; }
    }

    /// <remarks The CurveFeatureItemBaseType is the abstract base type for	shape feature items for features composed of curves./>
    public abstract class CurveFeatureItemBaseType : ShapeFeatureItemBaseType
    {
    }
}
