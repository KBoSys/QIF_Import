/*! \file SurfaceOfRevolutionFeatureMeasurementType.cs
    \brief defines the surface of revolution feature measurement information for an individual surface of revolution feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The SurfaceOfRevolutionFeatureMeasurementType defines the surface
    /// of revolution feature measurement information for an individual surface of revolution feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks> The optional Axis element gives the measured location of
        /// the start point and the measured unit axis vector of the
        /// surface of revolution.</remarks>
        public MeasuredAxisType Axis { get; set; }

        /// <remarks> The optional SweepMeasurementRange element gives the range
        /// over which the sweep for a partial surface of revolution
        /// feature was actually measured in terms of the start
        /// direction and the swept angle.The StartVector of the sweep
        /// must lie in a plane perpendicular to the axis of the
        /// surface of revolution feature.</remarks>
        public SweepType? SweepMeasurementRange { get; set; }

        /// <remarks> The optional SweepFull element gives the measured start
        /// direction and swept angle for a partial surface of
        /// revolution feature in terms of the start direction and
        /// swept angle. The StartVector of the SweepFull must lie in a
        /// plane perpendicular to the axis of the surface of revolution
        /// feature. This is intended for use when it has been possible
        /// to measure the start and end of the sweep.</remarks>
        public SweepType? SweepFull { get; set; }

        /// <remarks> The optional Length element gives the measured length of
        /// the surface of revolution from the measured start point in
        /// the direction of the axis of the surface of revolution.</remarks>
        public MeasuredLinearValueType? Length { get; set; }

        /// <remarks> The optional Form element is the form error (roundness) of
        /// the surface of revolution from a report or an analysis.</remarks>
        public MeasuredLinearValueType? Form { get; set; }
    }
}
