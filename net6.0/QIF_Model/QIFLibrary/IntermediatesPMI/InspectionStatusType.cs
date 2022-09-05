/*! \file InspectionStatusType.cs
    \brief defines the status of an inspection.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The InspectionStatusType defines the status of an inspection.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class InspectionStatusType
    {
        /// <remarks> The InspectionStatusEnum element describes an often-used status of an inspection.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("InspectionStatusEnum", typeof(InspectionStatusEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherInspectionStatus", typeof(string))]
        public object? Item { get; set; }
    }

    /// <remarks> The InspectionStatusEnumType enumerates values that describe the status of an inspection.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum InspectionStatusEnumType
    {

        /// <remarks></remarks>
        PASS,

        /// <remarks></remarks>
        FAIL,

        /// <remarks></remarks>
        REWORK,

        /// <remarks></remarks>
        SYSERROR,

        /// <remarks></remarks>
        UNKNOWN,

        /// <remarks></remarks>
        NOT_CALCULATED,

        /// <remarks></remarks>
        NOT_MEASURED,

        /// <remarks></remarks>
        UNDEFINED,
    }
}
