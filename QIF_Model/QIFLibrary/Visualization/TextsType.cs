/*! \file TextsType.cs
	\brief defines a number of 3D annotation text lines.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The TextsType defines a number of 3D annotation text lines./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TextsType
    {
        /// <remarks Each Text element is a string./>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public TextType[] Texts { get; set; }

        /// <remarks The required fontIndex attribute is the index of a font within the Fonts table./>
        [System.Xml.Serialization.XmlAttributeAttribute("fontIndex")]
        public uint FontIndex { get; set; }

        /// <remarks The optional lineHeight attribute is the height of the text line defined in the model units./>
        [System.Xml.Serialization.XmlAttributeAttribute("lineHeight")]
        public double LineHeight { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineHeightSpecified { get; set; }

        /// <remarks The required n attribute is the number of text strings in this array./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Texts.Length;
            set { }
        }
    }

    /// <remarks The TextType defines a 3D annotation text./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TextType
    {
        /// <remarks The Data element is a string./>
        public string Data { get; set; }

        /// <remarks The XY element specifies the 2D coordinates of the text anchor point.
        /// The 2D coordinates are defined in the visualization plane coordinate system./>
        public Point2dSimpleType XY { get; set; }
    }
}
