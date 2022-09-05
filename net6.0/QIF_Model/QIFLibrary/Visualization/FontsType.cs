/*! \file FontsType.cs
	\brief defines a container for storing all unique fonts used for model entities visualization.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Topology;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The AlignmentEnumType enumerates values that describe an alignment.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum AlignmentEnumType
    {
        /// <remarks></remarks>
        ALIGNMENT_LEFT,

        /// <remarks></remarks>
        ALIGNMENT_RIGHT,

        /// <remarks></remarks>
        ALIGNMENT_CENTER,
    }

    /// <remarks> The FontsType defines a container for storing all unique fonts used for model entities visualization.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FontsType : ArrayBaseType<FontType>
    {
        /// <remarks> Each Font element is a font which is used for visualization of 3D annotations.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Font")]
        public FontType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The FontType defines a font.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FontType
    {
        /// <remarks> The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType? Attributes { get; set; }

        /// <remarks> The Name element is the font name.</remarks>
        public string? Name { get; set; }

        /// <remarks> The Size element is the font size defined in points (typography, 1 pt = 1/72 inch).</remarks>
        public uint Size { get; set; }

        /// <remarks> The optional alignment element defines the note alignment, ALIGNMENT_LEFT is the default.</remarks>
        public AlignmentEnumType Alignment { get; set; } = AlignmentEnumType.ALIGNMENT_LEFT;

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlignmentSpecified { get; set; }

        /// <remarks> The required index attribute is an index identifying a font within the Fonts table.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("index")]
        public uint Index { get; set; }

        /// <remarks> The optional bold attribute shows if the written text must be bold.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("bold")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Bold { get; set; } = false;

        /// <remarks> The optional italic attribute shows if the written text must be italicized.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("italic")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Italic { get; set; } = false;

        /// <remarks> The optional underline attribute shows if the written text must be underlined.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("underline")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Underline { get; set; } = false;
    }
}
