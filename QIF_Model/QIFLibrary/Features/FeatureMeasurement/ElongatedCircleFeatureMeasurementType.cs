/*! \file ElongatedCircleFeatureMeasurementType.cs
    \brief defines the elongated circle feature measurement information for an individual elongated circle feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The ElongatedCircleFeatureMeasurementType defines the elongated
    /// circle feature measurement information for an individual elongated circle feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCircleFeatureMeasurementType : CurveFeatureMeasurementBaseType
    {
        /// <remarks> The optional Diameter element is the measured diameter of
        /// the elongated circle based on the substitute feature data
        /// fitting algorithm setting.</remarks>
        public MeasuredLinearValueType Diameter { get; set; }

        /// <remarks> The optional DiameterMin element is the minimum measured
        /// diameter of the elongated circle from a report or an analysis.</remarks>
        public MeasuredLinearValueType DiameterMin { get; set; }

        /// <remarks> The optional DiameterMax element is the maximum measured
        /// diameter of the elongated circle from a report or an analysis.</remarks>
        public MeasuredLinearValueType DiameterMax { get; set; }

        /// <remarks> The optional CenterLine element is the measured location
        /// point and a unit vector direction of the centerline of the
        /// elongated circle feature.</remarks>
        public MeasuredPointAndVectorType CenterLine { get; set; }

        /// <remarks> The optional Normal element is the measured normal vector
        /// of the plane of the elongated circle feature.</remarks>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks> The optional Length element is the measured length (i.e., size) of the elongated circle.</remarks>
        public MeasuredLinearValueType Length { get; set; }

        /// <remarks> The optional LengthMax element is the maximum length of the elongated circle from a report or an analysis.</remarks>
        public MeasuredLinearValueType LengthMax { get; set; }

        /// <remarks> The optional LengthMin element is the minimum length of the elongated circle from a report or an analysis.</remarks>
        public MeasuredLinearValueType LengthMin { get; set; }

        /// <remarks> The optional Form element is the form error (circularity) of the elongated circle from a report or an analysis.</remarks>
        public MeasuredLinearValueType Form { get; set; }
    }
}
