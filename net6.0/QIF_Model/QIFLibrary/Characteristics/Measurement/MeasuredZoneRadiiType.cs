/*! \file MeasuredZoneRadiiType.cs
    \brief defines the radial size limits of a measured tolerance zone evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The MeasuredZoneRadiiType defines the radial size limits of a measured tolerance zone evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredZoneRadiiType
    {
        /// <remarks> The MinRadius element is the minimum radius of the evaluated tolerance zone.</remarks>
        public MeasuredLinearValueType? MinRadius { get; set; }

        /// <remarks> The MaxRadius element is the maximum radius of the evaluated tolerance zone.</remarks>
        public MeasuredLinearValueType? MaxRadius { get; set; }
    }
}
