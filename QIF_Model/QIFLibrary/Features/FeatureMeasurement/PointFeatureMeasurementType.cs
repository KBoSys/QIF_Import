/*! \file PointFeatureMeasurementType.cs
    \brief defines the point feature measurement information for an individual point feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The PointFeatureMeasurementType defines the point feature measurement information for an individual point feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureMeasurementType : PointFeatureMeasurementBaseType
    {
        /// <remarks> The optional Location element is the measured location of the point.</remarks>
        public MeasuredPointType Location { get; set; }

        /// <remarks> The optional Normal element is the measured unit normal vector of the point.</remarks>
        public MeasuredUnitVectorType Normal { get; set; }
    }

}
