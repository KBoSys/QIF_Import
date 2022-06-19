/*! \file HatchStyleType.cs
	\brief defines a hatch style.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The HatchStyleType defines a hatch style./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchStyleType : NodeWithIdBaseType
    {
        /// <remarks The Form element is a hatch form./>
        public HatchStyleFormEnumType Form { get; set; }

        /// <remarks The optional Color element is a  color./>
        public ColorType Color { get; set; }

        /// <remarks The Patterns element is a hatch patterns./>
        public HatchPatternsType Patterns { get; set; }
    }

    /// <remarks The HatchStyleFormEnumType enumerates values that describe hatching styles./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum HatchStyleFormEnumType
    {
        /// <remarks/>
        NONE,

        /// <remarks/>
        PATTERN,

        /// <remarks/>
        FILL,

        /// <remarks/>
        ERASED,
    }

    /// <remarks The HatchPatternsType defines an array of hatch patterns./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchPatternsType
    {
        /// <remarks The Pattern element is a hatch pattern./>
        [System.Xml.Serialization.XmlElementAttribute("Pattern")]
        public HatchPatternType[] Items { get; set; }

        /// <remarks The required n attribute is the number of patterns in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The HatchPatternType defines a pattern of the hatching./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchPatternType
    {
        /// <remarks The optional LineStyle element is the line style of the hatching./>
        public LineStyleType LineStyle { get; set; }

        /// <remarks The FirstLineOrigin element is the origin of the first hatching line./>
        public Point2dSimpleType FirstLineOrigin { get; set; }

        /// <remarks The SecondLineOrigin element is the origin of the second hatching line./>
        public Point2dSimpleType SecondLineOrigin { get; set; }

        /// <remarks The Angle element is the angle of the hatching lines./>
        public AngularValueType Angle { get; set; }

        /// <remarks The optional Color element is the color of the hatching lines./>
        public ColorType Color { get; set; }
    }

    /// <remarks The HatchStyleSetType defines a collection of hatching styles./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchStyleSetType
    {
        /// <remarks Each HatchStyle element defines a hatching style./>
        [System.Xml.Serialization.XmlElementAttribute("HatchStyle")]
        public HatchStyleType[] Items { get; set; }

        /// <remarks The required n attribute is the number of hatching styles in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
