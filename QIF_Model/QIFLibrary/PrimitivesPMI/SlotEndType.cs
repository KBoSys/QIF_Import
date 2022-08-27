/*! \file SlotEndType.cs
	\brief defines the shape of the end of a slot.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The SlotEndType defines the shape of the end of a slot.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SlotEndType
    {
        /// <remarks>
        /// The OtherSlotEnd element describes the shape of the end of a slot in natural language.
        /// </remarks>
        [System.Xml.Serialization.XmlElementAttribute("OtherSlotEnd", typeof(string))]
        /// <remarks>
        /// The SlotEndEnum element describes an often-used shape of the end of a slot.
        /// </remarks>
        [System.Xml.Serialization.XmlElementAttribute("SlotEndEnum", typeof(SlotEndEnumType))]
        public object Item { get; set; }
    }

    /// <remarks> The SlotEndEnumType enumerates values that describe whether a slot has a round, flat(square), or open end.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SlotEndEnumType
    {
        /// <remarks></remarks>
        ROUND,

        /// <remarks></remarks>
        FLAT,

        /// <remarks></remarks>
        OPEN,

        /// <remarks></remarks>
        UNDEFINED,
    }
}
