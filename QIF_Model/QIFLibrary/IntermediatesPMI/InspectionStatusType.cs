/*! \file InspectionStatusType.cs
    \brief defines the status of an inspection.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The InspectionStatusType defines the status of an inspection./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class InspectionStatusType
    {
        /// <remarks The InspectionStatusEnum element describes an often-used status of an inspection./>
        [System.Xml.Serialization.XmlElementAttribute("InspectionStatusEnum", typeof(InspectionStatusEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherInspectionStatus", typeof(string))]
        public object Item { get; set; }
    }

    /// <remarks The InspectionStatusEnumType enumerates values that describe the status of an inspection./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum InspectionStatusEnumType
    {

        /// <remarks/>
        PASS,

        /// <remarks/>
        FAIL,

        /// <remarks/>
        REWORK,

        /// <remarks/>
        SYSERROR,

        /// <remarks/>
        UNKNOWN,

        /// <remarks/>
        NOT_CALCULATED,

        /// <remarks/>
        NOT_MEASURED,

        /// <remarks/>
        UNDEFINED,
    }
}
