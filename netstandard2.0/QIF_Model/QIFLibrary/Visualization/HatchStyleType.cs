/*! \file HatchStyleType.cs
	\brief defines a hatch style.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The HatchStyleType defines a hatch style.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchStyleType : NodeWithIdBaseType
    {
        /// <remarks> The Form element is a hatch form.</remarks>
        public HatchStyleFormEnumType Form { get; set; }

        /// <remarks> The optional Color element is a  color.</remarks>
        public ColorType Color { get; set; }

        /// <remarks> The Patterns element is a hatch patterns.</remarks>
        public HatchPatternsType Patterns { get; set; }
    }

    /// <remarks> The HatchStyleFormEnumType enumerates values that describe hatching styles.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum HatchStyleFormEnumType
    {
        /// <remarks></remarks>
        NONE,

        /// <remarks></remarks>
        PATTERN,

        /// <remarks></remarks>
        FILL,

        /// <remarks></remarks>
        ERASED,
    }

    /// <remarks> The HatchPatternsType defines an array of hatch patterns.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchPatternsType : ArrayBaseType<HatchPatternType>
    {
        /// <remarks> The Pattern element is a hatch pattern.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Pattern")]
        public HatchPatternType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The HatchPatternType defines a pattern of the hatching.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchPatternType
    {
        /// <remarks> The optional LineStyle element is the line style of the hatching.</remarks>
        public LineStyleType LineStyle { get; set; }

        /// <remarks> The FirstLineOrigin element is the origin of the first hatching line.</remarks>
        public Point2dSimpleType FirstLineOrigin { get; set; }

        /// <remarks> The SecondLineOrigin element is the origin of the second hatching line.</remarks>
        public Point2dSimpleType SecondLineOrigin { get; set; }

        /// <remarks> The Angle element is the angle of the hatching lines.</remarks>
        public AngularValueType Angle { get; set; }

        /// <remarks> The optional Color element is the color of the hatching lines.</remarks>
        public ColorType Color { get; set; }
    }

    /// <remarks> The HatchStyleSetType defines a collection of hatching styles.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchStyleSetType : ArrayBaseType<HatchStyleType>
    {
        /// <remarks> Each HatchStyle element defines a hatching style.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("HatchStyle")]
        public HatchStyleType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
