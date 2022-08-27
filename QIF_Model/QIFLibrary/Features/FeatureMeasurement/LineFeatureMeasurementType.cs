/*! \file LineFeatureMeasurementType.cs
    \brief defines the line feature measurement information for an individual line feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The LineFeatureMeasurementType defines the line feature measurement information for an individual line feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineFeatureMeasurementType : CurveFeatureMeasurementBaseType
    {
        /// <remarks> The optional Location element is the measured location of the start point of the line.</remarks>
        public MeasuredPointType Location { get; set; }

        /// <remarks> The optional Direction element is the measured unit vector representing the direction of the line.</remarks>
        public MeasuredUnitVectorType Direction { get; set; }

        /// <remarks> The optional Length element is the measured length of the line from the starting point in the line direction.</remarks>
        public MeasuredLinearValueType Length { get; set; }

        /// <remarks> The optional Normal element is the measured unit normal of the surface in which the line lies.</remarks>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks> The optional Form element is the form error (straightness) of the line from a report or an analysis.</remarks>
        public MeasuredLinearValueType Form { get; set; }
    }
}
