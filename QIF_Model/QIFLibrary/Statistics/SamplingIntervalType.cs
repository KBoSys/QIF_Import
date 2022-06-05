/*! \file SamplingIntervalType.cs
    \brief defines the sampling interval.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The SamplingIntervalType defines the sampling interval./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SamplingIntervalType
    {
        /// <remarks The SamplingIntervalEnum element describes an often-used sampling interval.
        /// The OtherSamplingInterval element describes the sampling interval in natural language./>
        [System.Xml.Serialization.XmlElementAttribute("OtherSamplingInterval", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SamplingIntervalEnum", typeof(SamplingIntervalEnumType))]
        public object Interval { get; set; }
    }

    /// <remarks The SamplingIntervalEnumType enumerates values that describe the sampling interval./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SamplingIntervalEnumType
    {
        /// <remarks/>
        SHIFT,

        /// <remarks/>
        DAY,

        /// <remarks/>
        HOUR,

        /// <remarks/>
        WEEK,

        /// <remarks/>
        MONTH,

        /// <remarks/>
        BATCH,

        /// <remarks/>
        LOT,
    }
}
