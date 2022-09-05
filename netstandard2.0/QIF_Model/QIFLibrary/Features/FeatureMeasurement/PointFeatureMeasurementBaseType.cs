/*! \file PointFeatureMeasurementBaseType.cs
    \brief abstract base type for shape feature measurements for features that are a point.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The PointFeatureMeasurementBaseType is the abstract base type for
    /// shape feature measurements for features that are a point.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFeatureMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PointFeatureMeasurementBaseType : ShapeFeatureMeasurementBaseType
    {
    }

    /// <remarks> The EdgePointFeatureMeasurementType defines the edge-point feature measurement information for an individual edge-point feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EdgePointFeatureMeasurementType : PointFeatureMeasurementBaseType
    {
        /// <remarks> The optional Location element is the measured location of a point on the edge between two surfaces.</remarks>
        public MeasuredPointType Location { get; set; }

        /// <remarks> The optional Normal element is the measured unit normal vector of the edge surface.</remarks>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks> The optional AdjacentNormal element is the measured unit normal vector of the surface adjacent to the edge surface.</remarks>
        public MeasuredUnitVectorType AdjacentNormal { get; set; }
    }
}
