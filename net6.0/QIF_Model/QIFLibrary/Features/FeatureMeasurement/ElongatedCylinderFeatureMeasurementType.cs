/*! \file ElongatedCylinderFeatureMeasurementType.cs
    \brief defines the elongated cylinder feature measurement information for an individual elongated cylinder feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The ElongatedCylinderFeatureMeasurementType defines the elongated
    /// cylinder feature measurement information for an individual elongated cylinder feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCylinderFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks> The optional Diameter element is the measured diameter of
        /// the elongated cylinder based on the substitute feature data
        /// fitting algorithm setting.</remarks>
        public MeasuredLinearValueType? Diameter { get; set; }

        /// <remarks> The optional DiameterMin element is the minimum measured
        /// diameter of the elongated cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? DiameterMin { get; set; }

        /// <remarks> The optional DiameterMax element is the maximum measured
        /// diameter of the elongated cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? DiameterMax { get; set; }

        /// <remarks> The optional CenterPlane element gives the measured
        /// location point and unit vector normal of the center plane
        /// of the measured elongated cylinder feature.The location
        /// point of the center plane is also the measured location
        /// point of the measured elongated cylinder feature and lies
        /// midway between the cylindrical ends.</remarks>
        public MeasuredPlaneType CenterPlane { get; set; }

        /// <remarks> The optional Length element is the measured length (i.e.,
        /// size) of the elongated cylinder.</remarks>
        public MeasuredLinearValueType? Length { get; set; }

        /// <remarks> The optional LengthMax element is the maximum length of the elongated cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? LengthMax { get; set; }

        /// <remarks> The optional LengthMin element is the minimum length of the elongated cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? LengthMin { get; set; }

        /// <remarks> The optional Depth element is the measured depth of the elongated cylinder.</remarks>
        public MeasuredLinearValueType? Depth { get; set; }

        /// <remarks> The optional DepthMax element is the maximum depth of the elongated cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? DepthMax { get; set; }

        /// <remarks> The optional DepthMin element is the minimum depth of the elongated cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? DepthMin { get; set; }

        /// <remarks> The optional DepthVector element is the measured unit vector
        /// direction of the depth of the measured elongated cylinder.
        /// The depth vector is parallel to the axis vector of each
        /// cylindrical end and points into the elongated cylinder.The
        /// elongated cylinder does not extend from the location point in the direction opposite the depth vector.</remarks>
        public MeasuredUnitVectorType? DepthVector { get; set; }

        /// <remarks> The optional Form element is the form error (cylindricity)
        /// of the elongated cylinder from a report or an analysis.</remarks>
        public MeasuredLinearValueType? Form { get; set; }
    }
}
