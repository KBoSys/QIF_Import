/*! \file CircleFeatureMeasurementType.cs
    \brief defines measurement information for an individual circle feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The CircleFeatureMeasurementType defines measurement information for an individual circle feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleFeatureMeasurementType : CurveFeatureMeasurementBaseType
    {
        /// <remarks> The optional Location element is the measured center point of the circle.</remarks>
        public MeasuredPointType Location { get; set; }

        /// <remarks> The optional Normal element is the measured normal vector of the plane of the circle.</remarks>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks> The optional Diameter element is the measured diameter of
        /// the circle based on the substitute feature data fitting algorithm setting.</remarks>
        public MeasuredLinearValueType Diameter { get; set; }

        /// <remarks> The optional DiameterMin element is the minimum measured diameter of the circle from a report or an analysis.</remarks>
        public MeasuredLinearValueType DiameterMin { get; set; }

        /// <remarks> The optional DiameterMax element is the maximum measured diameter of the circle from a report or an analysis.</remarks>
        public MeasuredLinearValueType DiameterMax { get; set; }

        /// <remarks> The optional Form element is the form error (roundness) of the circle from a report or an analysis.</remarks>
        public MeasuredLinearValueType Form { get; set; }

        /// <remarks> The optional SweepMeasurementRange element gives the range
        /// over which the sweep was actually measured in terms of the
        /// start direction and the swept angle.The StartVector of the sweep must lie in the plane of the circle.</remarks>
        public SweepType SweepMeasurementRange { get; set; }

        /// <remarks> The optional SweepFull element gives the measured start
        /// direction and swept angle.The StartVector of the sweep
        /// must lie in the plane of the circle.This is intended for
        /// use when it has been possible to measure the start and end of the sweep.</remarks>
        public SweepType SweepFull { get; set; }
    }
}
