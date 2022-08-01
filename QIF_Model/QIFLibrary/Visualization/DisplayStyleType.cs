/*! \file DisplayStyleType.cs
	\brief defines a display style of saved view elements

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The DisplayStyleType defines a display style of saved view elements, such as color, transparency and visualization form./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleType : NodeWithIdBaseType
    {
        /// <remarks The Mode element is the default displaying style./>
        public DisplayStyleModeType Mode { get; set; }

        /// <remarks The optional DisplayStyleGroups element is groups of elements with defined displaying style./>
        public DisplayStyleGroupsType DisplayStyleGroups { get; set; }
    }

    /// <remarks The DisplayStyleModeType defines a mode of the display style./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleModeType
    {
        /// <remarks The Form element is the displaying form for this style./>
        public DisplayStyleFormEnumType Form { get; set; }

        /// <remarks The optional Color element is the color for this style./>
        public ColorType Color { get; set; }

        /// <remarks The optional Transparency element is the value of the transparency for this style./>
        [System.ComponentModel.DefaultValueAttribute(0D)]
        public double Transparency { get; set; } = 0D;
    }

    /// <remarks The DisplayStyleFormEnumType enumerates values that describe display forms./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DisplayStyleFormEnumType
    {
        /// <remarks/>
        WIREFRAME,

        /// <remarks/>
        ISOLINES,

        /// <remarks/>
        ISOLINES_WITH_EDGES,

        /// <remarks/>
        SHADING,

        /// <remarks/>
        SHADING_WITH_EDGES,
    }

    /// <remarks The DisplayStyleGroupsType is a collection of the groups of  elements with defined displaying style./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleGroupsType
    {
        /// <remarks Each DisplayStyleGroup element is a group of elements with defined displaying style./>
        [System.Xml.Serialization.XmlElementAttribute("DisplayStyleGroup")]
        public DisplayStyleGroupType[] Groups { get; set; }

        /// <remarks The required n attribute is the number of elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Groups.Length;
            set { }
        }
    }

    /// <remarks The DisplayStyleGroupType defines a group of elements and its displaying style./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleGroupType
    {
        /// <remarks The Mode element is the display style of the group./>
        public DisplayStyleModeType Mode { get; set; }

        /// <remarks The optional ComponentIds element is an array of identifiers of the group components./>
        public ArrayReferenceFullType ComponentIds { get; set; }

        /// <remarks The optional BodyIds element is an array of identifiers of the group bodies./>
        public ArrayReferenceFullType BodyIds { get; set; }
    }

    /// <remarks The DisplayStyleSetType defines a collection of display style types./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleSetType
    {
        /// <remarks Each DisplayStyle element defines a display style./>
        [System.Xml.Serialization.XmlElementAttribute("DisplayStyle")]
        public DisplayStyleType[] Items { get; set; }

        /// <remarks The required n attribute is the number of display styles in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
