/*! \file SamplingIntervalType.cs
    \brief defines the sampling interval.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The SamplingIntervalType defines the sampling interval.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SamplingIntervalType
    {
        /// <remarks> The SamplingIntervalEnum element describes an often-used sampling interval.
        /// The OtherSamplingInterval element describes the sampling interval in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("OtherSamplingInterval", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SamplingIntervalEnum", typeof(SamplingIntervalEnumType))]
        public object Interval { get; set; }
    }

    /// <remarks> The SamplingIntervalEnumType enumerates values that describe the sampling interval.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SamplingIntervalEnumType
    {
        /// <remarks></remarks>
        SHIFT,

        /// <remarks></remarks>
        DAY,

        /// <remarks></remarks>
        HOUR,

        /// <remarks></remarks>
        WEEK,

        /// <remarks></remarks>
        MONTH,

        /// <remarks></remarks>
        BATCH,

        /// <remarks></remarks>
        LOT,
    }
}
