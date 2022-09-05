/*! \file LineStyleType.cs
	\brief defines a line style.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks> The LineStyleType defines a line style.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineStyleType
    {
        /// <remarks> The optional thickness attribute is the line thickness in pixels.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("thickness")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public uint Thickness { get; set; } = 1;

        /// <remarks> enumerates values that describe line styles.</remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public LineStyleEnumType Value { get; set; } = LineStyleEnumType.SOLID;
    }

    /// <remarks> The LineStyleEnumType enumerates values that describe line styles.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LineStyleEnumType
    {
        /// <remarks></remarks>
        SOLID,

        /// <remarks></remarks>
        DOT,

        /// <remarks></remarks>
        DASH,

        /// <remarks></remarks>
        DASH_DOT,

        /// <remarks></remarks>
        DASH_DOT_DOT,

        /// <remarks></remarks>
        DASH_DOT_DOT_DOT,

        /// <remarks></remarks>
        DASH_DASH_DOT,

        /// <remarks></remarks>
        DASH_DASH_DOT_DOT,

        /// <remarks></remarks>
        DASH_DASH_DOT_DOT_DOT,

        /// <remarks></remarks>
        SHORT_DASH,

        /// <remarks></remarks>
        LONG_DASH,

        /// <remarks></remarks>
        MEDIUM_LONG_DASH,

        /// <remarks></remarks>
        MEDIUM_DASH_SHORT_DASH_SHORT_DASH,

        /// <remarks></remarks>
        LONG_DASH_SHORT_DASH,

        /// <remarks></remarks>
        LONG_DASH_SHORT_DASH_SHORT_DASH,

        /// <remarks></remarks>
        LONG_DASH_DOT_DOT,

        /// <remarks></remarks>
        LONG_DASH_DOT,

        /// <remarks></remarks>
        MEDIUM_DASH_DOT_SHORT_DASH_DOT,

        /// <remarks></remarks>
        SPARSE_DOT,

        /// <remarks></remarks>
        CENTERLINE,

        /// <remarks></remarks>
        PHANTOM,
    }
}
