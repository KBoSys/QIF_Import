/*! \file NoteType.cs
	\brief note type

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks></remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoteFlagType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NoteType : DrawableBaseType
    {
        /// <remarks> The EntityInternalIds element is a list of the QIF ids of CAD entities associated with this note.</remarks>
        public ArrayReferenceFullType EntityInternalIds { get; set; }

        /// <remarks> The EntityExternalIds element is a list of the QIF ids of instances of EntityExternalType associated with this note.</remarks>
        public ArrayReferenceFullType EntityExternalIds { get; set; }

        /// <remarks> The Text element is the text of the Note.</remarks>
        public string Text { get; set; }

        /// <remarks> The form attribute specifies how the Note is represented.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        [System.ComponentModel.DefaultValueAttribute(NoteFormEnumType.Form3D)]
        public NoteFormEnumType Form { get; set; } = NoteFormEnumType.Form3D;

        [System.Xml.Serialization.XmlIgnore]
        bool FormSpecified { get; set; }
    }

    /// <remarks> The NoteFormType enumerates values that describe the form of the Note</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum NoteFormEnumType
    {
        /// <remarks> Note defined on the 3D annotation plane</remarks>
        [System.Xml.Serialization.XmlEnumAttribute("3D")]
        Form3D,

        /// <remarks> Note defined as flat to screen</remarks>
        SCREEN,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NoteFlagType : NoteType
    {
        /// <remarks> The optional TextHidden element is the hidden text of the flag note.</remarks>
        public string TextHidden { get; set; }

        /// <remarks> The optional URI element is a Uniform Resource Identifier
        /// for the information, which may be, for example, a file or a web site.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public UriType URI { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PartNoteType : DrawableBaseType
    {
        /// <remarks> The optional Text element is the text of the PartNote.</remarks>
        public string Text { get; set; }

        /// <remarks> The optional PartNoteIds element is an array of identifiers of nested part notes.</remarks>
        public ArrayReferenceType PartNoteIds { get; set; }
    }
}
