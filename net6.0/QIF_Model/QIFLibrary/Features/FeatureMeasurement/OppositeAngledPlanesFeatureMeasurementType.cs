/*! \file OppositeAngledPlanesFeatureMeasurementType.cs
    \brief defines the opposite angled planes feature measurement information for an individual opposite angled planes feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum DraftOrTaperAngleEnum
    {
        /// <remarks></remarks>
        DraftAngle,

        /// <remarks></remarks>
        TaperAngle,
    }

    /// <remarks> The OppositeAngledPlanesFeatureMeasurementType defines the opposite
    /// angled planes feature measurement information for an individual opposite angled planes feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks> The optional CenterPlane element is the measured location
        /// point and a unit vector normal of the center plane of the
        /// opposite angled planes feature.</remarks>
        public MeasuredPlaneType CenterPlane { get; set; }

        /// <remarks> The optional LengthVector element is the measured unit
        /// vector of the long axis of the feature.</remarks>
        public MeasuredUnitVectorType? LengthVector { get; set; }

        /// <remarks> The optional DepthVector element is the measured unit vector of the depth axis of the feature.</remarks>
        public MeasuredUnitVectorType? DepthVector { get; set; }

        /// <remarks> The optional Width element is the measured width between the
        /// opposite angled planes per the substitute feature data
        /// fitting algorithm setting.Because the feature is tapered
        /// or has draft, the width applies at the locating point.</remarks>
        public MeasuredLinearValueType? Width { get; set; }

        /// <remarks> The optional WidthMin element is the minimum width of the
        /// opposite angled planes feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType? WidthMin { get; set; }

        /// <remarks> The optional WidthMax element is the maximum width of the
        /// opposite angled planes feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType? WidthMax { get; set; }

        /// <remarks> The optional Length element is the measured length of the
        /// opposite angled planes feature based on the substitute
        /// feature data fitting algorithm setting.If the feature has
        /// draft then the length applies at the locating point.</remarks>
        public MeasuredLinearValueType? Length { get; set; }

        /// <remarks> The optional LengthMin element is the minimum length of the
        /// opposite angled planes feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType? LengthMin { get; set; }

        /// <remarks> The optional LengthMax element is the maximum length of the
        /// opposite angled planes feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType? LengthMax { get; set; }

        /// <remarks> The optional Depth element is the measured depth of opposite angled planes feature in the direction of the depth vector.</remarks>
        public MeasuredLinearValueType? Depth { get; set; }

        /// <remarks> This optional compositor allows for a taper angle or a draft angle, but not both.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DraftAngle", typeof(MeasuredAngularValueType))]
        [System.Xml.Serialization.XmlElementAttribute("TaperAngle", typeof(MeasuredAngularValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public MeasuredAngularValueType? Item { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public DraftOrTaperAngleEnum ItemElementName { get; set; }

        /// <remarks> The optional EndRadius1 element is the measured radius of
        /// the rounded end in the direction opposite the length vector.</remarks>
        public MeasuredEndRadiusType EndRadius1 { get; set; }

        /// <remarks> The optional EndRadius2 element is the measured radius of
        /// the rounded end in the direction of the length vector.</remarks>
        public MeasuredEndRadiusType EndRadius2 { get; set; }

        /// <remarks> The optional Form element is the form error of the opposite
        /// angled planes feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType? Form { get; set; }
    }
}
