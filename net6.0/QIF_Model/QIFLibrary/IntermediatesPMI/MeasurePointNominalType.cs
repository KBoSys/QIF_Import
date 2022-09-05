/*! \file MeasurePointNominalType.cs
    \brief defines a nominal measure point.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The MeasurePointNominalType defines a nominal measure point. In a
    /// MeasurePointNominalType, the inherited Point element is the
    /// location of a point at which a measurement is to be taken, and the
    /// inherited Normal element is a vector pointing opposite an intended
    /// approach direction for measurement.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasurePointNominalType : PointWithNormalBaseType
    {
        /// <remarks> The optional MeasurementDeviceId element is the QIF id of
        /// the measurement device to be used to measure the point.</remarks>
        public QIFReferenceType? MeasurementDeviceId { get; set; }

        /// <remarks> The optional SensorId element is the QIF id of the sensor (e.g., tactile probe) to be used to measure the point.</remarks>
        public QIFReferenceType? SensorId { get; set; }

        /// <remarks> The optional TipId element is the QIF id of the tip of a
        /// complex tactile probe to be used to measure the point.
        /// This must be the id of a ProbeTipType object.</remarks>
        public QIFReferenceType? TipId { get; set; }
    }

    /// <remarks> The MeasuredPointAndVectorType defines a line by its starting point and direction vector.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredPointAndVectorType
    {
        /// <remarks> The StartPoint element is the measured starting point of the line.</remarks>
        public MeasuredPointType? StartPoint { get; set; }

        /// <remarks> The Vector element is a unit vector giving the measured direction of the line.</remarks>
        public MeasuredUnitVectorType? Vector { get; set; }
    }

    /// <remarks> The MeasuredEndRadiusType defines the measured radius of the end of a slot.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredEndRadiusType
    {
        /// <remarks> The EndRadius element describes the measured end radius of the slot.</remarks>
        public Units.MeasuredLinearValueType? EndRadius { get; set; }

        /// <remarks> The optional Expanded element when set to "true" indicates that
        /// the round end of a slot expands to be larger than the width like the end of a dumbbell.</remarks>
        public bool Expanded { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpandedSpecified { get; set; }
    }
}
