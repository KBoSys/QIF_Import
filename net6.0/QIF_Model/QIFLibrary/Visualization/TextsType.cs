/*! \file TextsType.cs
	\brief defines a number of 3D annotation text lines.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The TextsType defines a number of 3D annotation text lines.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TextsType : ArrayBaseType<TextType>
    {
        /// <remarks> Each Text element is a string.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public TextType[]? Items { get => base.itemsField; set => base.itemsField = value; }

        /// <remarks> The required fontIndex attribute is the index of a font within the Fonts table.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("fontIndex")]
        public uint FontIndex { get; set; }

        /// <remarks> The optional lineHeight attribute is the height of the text line defined in the model units.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("lineHeight")]
        public double LineHeight { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineHeightSpecified { get; set; }
    }

    /// <remarks> The TextType defines a 3D annotation text.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TextType
    {
        /// <remarks> The Data element is a string.</remarks>
        public string? Data { get; set; }

        /// <remarks> The XY element specifies the 2D coordinates of the text anchor point.
        /// The 2D coordinates are defined in the visualization plane coordinate system.</remarks>
        public Point2dSimpleType? XY { get; set; }
    }
}
