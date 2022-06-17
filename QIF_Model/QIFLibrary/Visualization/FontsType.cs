/*! \file FontsType.cs
	\brief defines a container for storing all unique fonts used for model entities visualization.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The AlignmentEnumType enumerates values that describe an alignment./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum AlignmentEnumType
    {
        /// <remarks/>
        ALIGNMENT_LEFT,

        /// <remarks/>
        ALIGNMENT_RIGHT,

        /// <remarks/>
        ALIGNMENT_CENTER,
    }

    /// <remarks The FontsType defines a container for storing all unique fonts used for model entities visualization./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FontsType
    {
        /// <remarks Each Font element is a font which is used for visualization of 3D annotations./>
        [System.Xml.Serialization.XmlElementAttribute("Font")]
        public FontType[] Items { get; set; }

        /// <remarks The required n attribute is the number of fonts in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }

    /// <remarks The FontType defines a font./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FontType
    {
        /// <remarks The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks The Name element is the font name./>
        public string Name { get; set; }

        /// <remarks The Size element is the font size defined in points (typography, 1 pt = 1/72 inch)./>
        public uint Size { get; set; }

        /// <remarks The optional alignment element defines the note alignment, ALIGNMENT_LEFT is the default./>
        public AlignmentEnumType Alignment { get; set; } = AlignmentEnumType.ALIGNMENT_LEFT;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlignmentSpecified { get; set; }

        /// <remarks The required index attribute is an index identifying a font within the Fonts table./>
        [System.Xml.Serialization.XmlAttributeAttribute("index")]
        public uint Index { get; set; }

        /// <remarks The optional bold attribute shows if the written text must be bold./>
        [System.Xml.Serialization.XmlAttributeAttribute("bold")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Bold { get; set; } = false;

        /// <remarks The optional italic attribute shows if the written text must be italicized./>
        [System.Xml.Serialization.XmlAttributeAttribute("italic")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Italic { get; set; } = false;

        /// <remarks The optional underline attribute shows if the written text must be underlined./>
        [System.Xml.Serialization.XmlAttributeAttribute("underline")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Underline { get; set; } = false;
    }
}
