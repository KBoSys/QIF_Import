/*! \file ExtrudedCrossSectionFeatureMeasurementType.cs
    \brief defines the extruded cross-section feature measurement information for an individual extruded cross-section feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The ExtrudedCrossSectionFeatureMeasurementType defines the extruded
    /// cross-section feature measurement information for an individual extruded cross-section feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks> The optional Direction element is the vector representing
        /// the direction along which the cross-section is extruded.</remarks>
        public MeasuredUnitVectorType? Direction { get; set; }

        /// <remarks> The optional Length element is the length over which the
        /// extruded cross-section is extruded.</remarks>
        public MeasuredLinearValueType? Length { get; set; }

        /// <remarks> The optional Form element is the form error (straightness)
        /// of the extruded cross-section from a report or an analysis.</remarks>
        public MeasuredLinearValueType? Form { get; set; }
    }
}
