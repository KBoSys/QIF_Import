/*! \file FeatureMeasurementBaseType.cs
    \brief 
        The abstract global FeatureMeasurement element is the head of a
        substitution group. Any element that is a member of the group may
        be substituted for the FeatureMeasurement element anywhere the
        FeatureMeasurement element could be used in an instance file if it
        were not abstract.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The FeatureMeasurementBaseType is the abstract base type for
    /// feature measurements.A feature measurement holds all information
    /// for a directly measured or constructed feature, e.g.feature size
    /// and feature location./>
    public abstract class FeatureMeasurementBaseType : FeatureBaseType
    {
        /// <remarks The optional FeatureItemId element is the QIF id of the
        /// associated feature item(which will reference feature nominal information)./>
        [XmlElement()]
        public Primitives.QIFReferenceType FeatureItemId { get; set; }

        /// <remarks The optional FeatureName element is the name of the measured
        /// feature, e.g.CIRC1, PLANE_3.If this element is not present
        /// then the feature name will be that defined by the referenced feature item./>
        [XmlElement()]
        public string FeatureName { get; set; }

        /// <remarks The optional TimeStamp element is the date and time at which
        /// the feature was measured./>
        [XmlElement()]
        public DateTime TimeStamp { get; set; }

        /// <remarks The optional ActualComponentId element is the QIF id of the
        /// actual component to which this feature actual belongs./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType ActualComponentId { get; set; }

        /// <remarks The optional ManufacturingProcessId element is a reference
        /// to the traceability information for the process used to manufacture this feature./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType ManufacturingProcessId { get; set; }

        /// <remarks The optional MeasurementDeviceIds element is a list of
        /// references to the measurement devices used in the inspection of the feature./>
        [XmlElement()]
        public Primitives.ArrayReferenceFullType MeasurementDeviceIds { get; set; }

        /// <remarks The optional ActualTransformId element is the QIF id of the
        /// actual coordinate system or actual DRF transform in which
        /// this measured feature originated.Note: any coordinate or
        /// vector information defining the measured feature is in
        /// terms of the common coordinate system. The actual transform
        /// is used to map coordinate and vector information between
        /// the common coordinate system and the actual coordinate system or actual DRF./>
        [XmlElement()]
        public Primitives.QIFReferenceType ActualTransformId { get; set; }

        /// <remarks The optional NotedEventIds element is a list of QIF ids of
        /// noted events that happened during the measurement of this feature./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType NotedEventIds { get; set; }
    }

    /// <remarks The ShapeFeatureMeasurementBaseType is the abstract base type for
    /// shape feature measurements.A shape feature measurement holds all
    /// information for a measured or constructed shape feature, e.g.
    /// feature size and feature location./>
    public abstract class ShapeFeatureMeasurementBaseType : FeatureMeasurementBaseType
    {
        /// <remarks The optional PointList element is a list of references to
        /// measured points for the feature./>
        [XmlElement()]
        public PointListType PointList { get; set; }

        /// <remarks The optional SubstituteFeatureAlgorithm element is the
        /// actual substitute feature data fitting algorithm used for
        /// the shape feature measurement.This setting may differ from
        /// any substitute feature algorithm defined on the feature
        /// nominal or feature item./>
        [XmlElement()]
        public IntermediatesPMI.SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }

        /// <remarks The optional ProxyMeasurementId element is the QIF id of a
        /// feature measurement which acts as a proxy replacing this
        /// feature measurement. For example a line measurement might
        /// be a proxy for a plane measurement when not enough actual
        /// measurement points were taken to establish a plane./>
        [XmlElement()]
        public Primitives.QIFReferenceType ProxyMeasurementId { get; set; }
    }

    /// <remarks The OtherShapeFeatureMeasurementType defines the other shape feature measurement information for an individual other shape feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherShapeFeatureMeasurementType : ShapeFeatureMeasurementBaseType
    {
    }

    /// <remarks The CurveFeatureMeasurementBaseType is the abstract base type for shape feature measurements for features composed of curves./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CurveFeatureMeasurementBaseType : ShapeFeatureMeasurementBaseType
    {
    }

    /// <remarks The OtherCurveFeatureMeasurementType defines the other curve feature
    /// measurement information for an individual other curve feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherCurveFeatureMeasurementType : CurveFeatureMeasurementBaseType
    {
    }
}
