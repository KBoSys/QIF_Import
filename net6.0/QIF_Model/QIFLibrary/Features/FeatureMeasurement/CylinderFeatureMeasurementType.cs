/*! \file CylinderFeatureMeasurementType.cs
    \brief defines the cylinder feature measurement information for an individual cylinder feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The CylinderFeatureMeasurementType defines the cylinder feature measurement information for an individual cylinder feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks> The optional Axis element gives the measured location of
        /// the start point and the measured unit vector of the
        /// cylinder axis.The direction of the axis vector points into the cylinder. 
        /// The cylinder does not extend from the start point in the direction opposite the axis vector.</remarks>
        public MeasuredAxisType Axis { get; set; }

        /// <remarks> The optional Diameter element is the measured diameter of
        /// the cylinder based on the substitute feature data fitting algorithm setting.</remarks>
        public MeasuredLinearValueType? Diameter { get; set; }

        /// <remarks> The optional Length element is the measured length of the
        /// cylinder from the start point in the direction of the cylinder axis.</remarks>
        public MeasuredLinearValueType? Length { get; set; }

        /// <remarks> The optional DiameterMin element is the minimum diameter of the cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? DiameterMin { get; set; }

        /// <remarks> The optional DiameterMax element is the maximum diameter of the cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? DiameterMax { get; set; }

        /// <remarks> The optional SweepMeasurementRange element gives the range
        /// over which the sweep for a partial cylinder feature was
        /// actually measured in terms of the start direction the swept angle. 
        /// The StartVector of the sweep must lie in a plane perpendicular to the axis of the cylinder.</remarks>
        public SweepType? SweepMeasurementRange { get; set; }

        /// <remarks> The optional SweepFull element gives the measured start
        /// direction and swept angle for a partial cylinder feature
        /// in terms of the start direction and swept angle.The
        /// StartVector of the SweepFull must lie in a plane
        /// perpendicular to the axis of the cylinder.This is intended
        /// for use when it has been possible to measure the start and end of the sweep.</remarks>
        public SweepType? SweepFull { get; set; }

        /// <remarks> The optional Form element is the form error (cylindricity)
        /// of the cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? Form { get; set; }
    }

    /// <remarks> The CylindricalSegmentFeatureMeasurementType defines the
    /// cylindrical segment feature measurement information for an
    /// individual cylindrical segment feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylindricalSegmentFeatureMeasurementType : CylinderFeatureMeasurementType
    {
    }
}
