/*! \file NoteSetType.cs
	\brief a list with notes

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications.QIFPlan;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NoteSetType : ArrayBaseType<NoteType>
    {
        /// <remarks> Each Note element is a note.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public NoteType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
