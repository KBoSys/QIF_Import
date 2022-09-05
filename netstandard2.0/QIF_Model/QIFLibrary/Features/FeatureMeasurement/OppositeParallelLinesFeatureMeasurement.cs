/*! \file OppositeParallelLinesFeatureMeasurementType.cs
    \brief defines the opposite parallel lines feature measurement information for an individual opposite parallel lines feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The OppositeParallelLinesFeatureMeasurementType defines the opposite
    /// parallel lines feature measurement information for an individual
    /// opposite parallel lines feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesFeatureMeasurementType : CurveFeatureMeasurementBaseType
    {
        /// <remarks> The optional CenterLine element is the measured location
        /// point and a unit vector direction of the centerline of the opposite parallel lines feature.</remarks>
        public MeasuredPointAndVectorType CenterLine { get; set; }

        /// <remarks> The optional Normal element is the measured unit normal vector of the plane of the opposite parallel lines feature.</remarks>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks> The optional Width element is the measured width between the
        /// opposite parallel lines of the feature per the substitute feature data fitting algorithm setting.</remarks>
        public MeasuredLinearValueType Width { get; set; }

        /// <remarks> The optional WidthMin element is the minimum width of the
        /// opposite parallel lines feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType WidthMin { get; set; }

        /// <remarks> The optional WidthMax element is the maximum width of the
        /// opposite parallel lines feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType WidthMax { get; set; }

        /// <remarks> The optional Length element is the measured length of the
        /// centerline of the opposite parallel lines feature based on
        /// the substitute feature data fitting algorithm setting.</remarks>
        public MeasuredLinearValueType Length { get; set; }

        /// <remarks> The optional LengthMin element is the minimum length of the
        /// opposite parallel lines feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType LengthMin { get; set; }

        /// <remarks> The optional LengthMax element is the maximum length of the
        /// opposite parallel lines feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType LengthMax { get; set; }

        /// <remarks> The optional EndRadius1 element is the measured radius of
        /// the rounded end in the direction opposite the centerline vector.</remarks>
        public MeasuredEndRadiusType EndRadius1 { get; set; }

        /// <remarks> The optional EndRadius2 element is the measured radius of
        /// the rounded end in the direction of the centerline vector.</remarks>
        public MeasuredEndRadiusType EndRadius2 { get; set; }

        /// <remarks> The optional Form element is the form error of the opposite
        /// parallel lines feature from a report or an analysis.</remarks>
        public MeasuredLinearValueType Form { get; set; }
    }
}
