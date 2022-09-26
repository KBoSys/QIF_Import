/*! \file FontStyle.cs
	\brief Defines the size, family, and style used for Text nodes

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// justifyChoices are strictly allowed enumeration values for justify field in FontStyle and ScreenFontStyle nodes
    /// determining major and minor axis alignment(typically horizontal and vertical) of text layout.
    /// Note that intermediate commas and extraneous whitespace are disallowed by these strictly defined enumeration values.
    /// This list is bounded, no additional values are allowed.
    /// </summary>
    public enum JustifyChoices
    {
        [XmlEnum("MIDDLE")]
        MIDDLE = 0x0001,

        [XmlEnum("BEGIN")]
        BEGIN = 0x0002,

        [XmlEnum("END")]
        END = 0x0004,

        [XmlEnum("FIRST")]
        FIRST = 0x0008,

        [XmlEnum("MIDDLE BEGIN")]
        MIDDLE_BEGIN = MIDDLE << 1 | BEGIN,

        [XmlEnum("MIDDLE END")]
        MIDDLE_END = MIDDLE << 1 | END,

        [XmlEnum("MIDDLE FIRST")]
        MIDDLE_FIRST = MIDDLE << 1 | FIRST,

        [XmlEnum("MIDDLE MIDDLE")]
        MIDDLE_MIDDLE = MIDDLE << 1 | MIDDLE,

        [XmlEnum("BEGIN BEGIN")]
        BEGIN_BEGIN = BEGIN << 1 | BEGIN,

        [XmlEnum("BEGIN END")]
        BEGIN_END = BEGIN << 1 | END,

        [XmlEnum("BEGIN FIRST")]
        BEGIN_FIRST = BEGIN << 1 | FIRST,

        [XmlEnum("BEGIN MIDDLE")]
        BEGIN_MIDDLE = BEGIN << 1 | MIDDLE,

        [XmlEnum("END BEGIN")]
        END_BEGIN = END << 1 | BEGIN,

        [XmlEnum("END END")]
        END_END = END << 1 | END,

        [XmlEnum("END FIRST")]
        END_FIRST = END << 1 | FIRST,

        [XmlEnum("END MIDDLE")]
        END_MIDDLE = END << 1 | MIDDLE,

        [XmlEnum("FIRST BEGIN")]
        FIRST_BEGIN = FIRST << 1 | BEGIN,

        [XmlEnum("FIRST END")]
        FIRST_END = FIRST << 1 | END,

        [XmlEnum("FIRST FIRST")]
        FIRST_FIRST = FIRST << 1 | FIRST,

        [XmlEnum("FIRST MIDDLE")]
        FIRST_MIDDLE = FIRST << 1 | MIDDLE,
    }

    /// <summary>
    /// fontStyleChoices are strictly allowed enumeration values for FontStyle/ScreenFontStyle node style field. 
    /// This list is bounded, no additional values are allowed.
    /// </summary>
    public enum FontStyleChoices
    {
        PLAIN,
        BOLD,
        ITALIC,
        BOLDITALIC,
    }

    /// <summary>
    /// The FontStyle node defines the size, family, and style used for Text nodes
    /// </summary>
    public class FontStyle : X3DFontStyleNode
    {
        [XmlAttribute("family")]
        [System.ComponentModel.DefaultValueAttribute("SERIF")]
        public string Family { get; set; } = "SERIF";

        [XmlAttribute("horizontal")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Horizontal { get; set; } = true;

        [XmlAttribute("justify")]
        [System.ComponentModel.DefaultValueAttribute(JustifyChoices.BEGIN)]
        public JustifyChoices Justify { get; set; } = JustifyChoices.BEGIN;

        [XmlAttribute("language")]
        public string? Language { get; set; }

        [XmlAttribute("leftToRigh")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool LeftToRigh { get; set; } = true;

        [XmlAttribute("size")]
        [System.ComponentModel.DefaultValueAttribute(1.0f)]
        public float Size { get; set; } = 1.0f;

        [XmlAttribute("spacing")]
        [System.ComponentModel.DefaultValueAttribute(1.0f)]
        public float Spacing { get; set; } = 1.0f;

        [XmlAttribute("style")]
        [System.ComponentModel.DefaultValueAttribute(FontStyleChoices.PLAIN)]
        public FontStyleChoices Style { get; set; } = FontStyleChoices.PLAIN;

        [XmlAttribute("topToBottom")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool TopToBottom { get; set; } = true;

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("fontStyle")]
        public string Container { get; set; } = "fontStyle";
    }

    /// <summary>
    /// The ScreenFontStyle node specifies font styles in terms of the characteristics of a particular presentation surface upon which the text is to be rendered.
    /// </summary>
    public class ScreenFontStyle : X3DFontStyleNode
    {
        [XmlAttribute("family")]
        [System.ComponentModel.DefaultValueAttribute("SERIF")]
        public string Family { get; set; } = "SERIF";

        [XmlAttribute("horizontal")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Horizontal { get; set; } = true;

        [XmlAttribute("justify")]
        [System.ComponentModel.DefaultValueAttribute(JustifyChoices.BEGIN)]
        public JustifyChoices Justify { get; set; } = JustifyChoices.BEGIN;

        [XmlAttribute("language")]
        public string? Language { get; set; }

        [XmlAttribute("leftToRigh")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool LeftToRigh { get; set; } = true;

        [XmlAttribute("pointSize")]
        [System.ComponentModel.DefaultValueAttribute(12.0f)]
        public float Size { get; set; } = 12.0f;

        [XmlAttribute("spacing")]
        [System.ComponentModel.DefaultValueAttribute(1.0f)]
        public float Spacing { get; set; } = 1.0f;

        [XmlAttribute("style")]
        [System.ComponentModel.DefaultValueAttribute(FontStyleChoices.PLAIN)]
        public FontStyleChoices Style { get; set; } = FontStyleChoices.PLAIN;

        [XmlAttribute("topToBottom")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool TopToBottom { get; set; } = true;

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("fontStyle")]
        public string Container { get; set; } = "fontStyle";
    }
}
