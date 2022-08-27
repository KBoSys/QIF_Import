/*! \file NoteSetType.cs
	\brief a list with notes

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NoteSetType
    {
        /// <remarks> Each Note element is a note.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public NoteType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of notes in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
