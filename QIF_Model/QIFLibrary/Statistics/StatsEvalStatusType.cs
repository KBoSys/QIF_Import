/*! \file StatsEvalStatusType.cs
    \brief defines the status of a statistical evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The StatsEvalStatusType defines the status of a statistical evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsEvalStatusType
    {
        /// <remarks
        /// The StatsEvalStatusEnum element describes an often-used status of a statistical evaluation.
        /// The OtherStatsEvalStatus element describes the status of a statistical evaluation in natural language./>
        [System.Xml.Serialization.XmlElementAttribute("OtherStatsEvalStatus", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("StatsEvalStatusEnum", typeof(StatsEvalStatusEnumType))]
        public object Item { get; set; }
    }

    /// <remarks The StatsEvalStatusEnumType enumerates values that describe the status of a statistical evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum StatsEvalStatusEnumType
    {
        /// <remarks/>
        PASS,

        /// <remarks/>
        FAIL,

        /// <remarks/>
        INFORMATIONAL,

        /// <remarks/>
        UNDEFINED,
    }
}
