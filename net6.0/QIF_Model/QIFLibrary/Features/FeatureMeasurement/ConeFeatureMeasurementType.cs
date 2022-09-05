/*! \file ConeFeatureMeasurementType.cs
    \brief defines the cone feature measurement information for an individual cone feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.FeatureDefinitions;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The ConeFeatureMeasurementType defines the cone feature measurement information for an individual cone feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks> The optional Axis element is the measured XYZ locating
        /// point and unit axis vector of the cone which points from
        /// the locating point into the expanding end of the cone.</remarks>
        public MeasuredAxisType? Axis { get; set; }

        /// <remarks> The optional Diameter element is the measured diameter of
        /// the the cone at the locating point.If the measured
        /// locating point is at the vertex this value will be zero.</remarks>
        public MeasuredLinearValueType? Diameter { get; set; }

        /// <remarks> The optional DiameterMin element is the measured minimum
        /// diameter at the locating point of the cone from a report or an analysis.</remarks>
        public MeasuredLinearValueType? DiameterMin { get; set; }

        /// <remarks> The optional DiameterMax element is the measured maximum
        /// diameter at the locating point of the cone from a report or an analysis.</remarks>
        public MeasuredLinearValueType? DiameterMax { get; set; }

        /// <remarks> This optional compositor defines the measured angle of the cone.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FullAngle", typeof(MeasuredAngularValueType))]
        [System.Xml.Serialization.XmlElementAttribute("HalfAngle", typeof(MeasuredAngularValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public MeasuredAngularValueType? Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ConeAngleTypeEnum ItemElementName { get; set; }

        /// <remarks> The optional SmallEndDistance element is the measured
        /// distance from the locating point to the small end of a
        /// truncated cone along the axis vector.If the cone has a
        /// pointed end then this element must be omitted.</remarks>
        public MeasuredLinearValueType? SmallEndDistance { get; set; }

        /// <remarks> The optional LargeEndDistance element is the measured
        /// distance from the locating point to the large end of a truncated cone along the axis vector.</remarks>
        public MeasuredLinearValueType? LargeEndDistance { get; set; }

        /// <remarks> The optional SweepMeasurementRange element gives the range
        /// over which the sweep for a partial cone feature was
        /// actually measured in terms of the start direction the swept angle. 
        /// The StartVector of the sweep must lie in a plane perpendicular to the axis of the cone.</remarks>
        public SweepType? SweepMeasurementRange { get; set; }

        /// <remarks> The optional SweepFull element gives the measured start
        /// direction and swept angle for a partial cone feature in
        /// terms of the start direction and swept angle.The
        /// StartVector of the SweepFull must lie in a plane
        /// perpendicular to the axis of the cone.This is intended for
        /// use when it has been possible to measure the start and end of the sweep.</remarks>
        public SweepType? SweepFull { get; set; }

        /// <remarks> The optional Form element is the form error (conicity) of the cone from a report or an analysis.</remarks>
        public MeasuredLinearValueType? Form { get; set; }
    }

    /// <remarks> The ConicalSegmentFeatureMeasurementType defines the conical
    /// segment feature measurement information for an individual conical segment feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalSegmentFeatureMeasurementType : ConeFeatureMeasurementType
    {
    }
}
