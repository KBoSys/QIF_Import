/*! \file DisplayStyleType.cs
	\brief defines a display style of saved view elements

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using QIF_Model.QIFLibrary.Topology;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The DisplayStyleType defines a display style of saved view elements, such as color, transparency and visualization form.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleType : NodeWithIdBaseType
    {
        /// <remarks> The Mode element is the default displaying style.</remarks>
        public DisplayStyleModeType Mode { get; set; }

        /// <remarks> The optional DisplayStyleGroups element is groups of elements with defined displaying style.</remarks>
        public DisplayStyleGroupsType DisplayStyleGroups { get; set; }
    }

    /// <remarks> The DisplayStyleModeType defines a mode of the display style.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleModeType
    {
        /// <remarks> The Form element is the displaying form for this style.</remarks>
        public DisplayStyleFormEnumType Form { get; set; }

        /// <remarks> The optional Color element is the color for this style.</remarks>
        public ColorType? Color { get; set; }

        /// <remarks> The optional Transparency element is the value of the transparency for this style.</remarks>
        [System.ComponentModel.DefaultValueAttribute(0D)]
        public double Transparency { get; set; } = 0D;
    }

    /// <remarks> The DisplayStyleFormEnumType enumerates values that describe display forms.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DisplayStyleFormEnumType
    {
        /// <remarks></remarks>
        WIREFRAME,

        /// <remarks></remarks>
        ISOLINES,

        /// <remarks></remarks>
        ISOLINES_WITH_EDGES,

        /// <remarks></remarks>
        SHADING,

        /// <remarks></remarks>
        SHADING_WITH_EDGES,
    }

    /// <remarks> The DisplayStyleGroupsType is a collection of the groups of  elements with defined displaying style.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleGroupsType : ArrayBaseType<DisplayStyleGroupType>
    {
        /// <remarks> Each DisplayStyleGroup element is a group of elements with defined displaying style.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DisplayStyleGroup")]
        public DisplayStyleGroupType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The DisplayStyleGroupType defines a group of elements and its displaying style.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleGroupType
    {
        /// <remarks> The Mode element is the display style of the group.</remarks>
        public DisplayStyleModeType Mode { get; set; }

        /// <remarks> The optional ComponentIds element is an array of identifiers of the group components.</remarks>
        public ArrayReferenceFullType? ComponentIds { get; set; }

        /// <remarks> The optional BodyIds element is an array of identifiers of the group bodies.</remarks>
        public ArrayReferenceFullType? BodyIds { get; set; }
    }

    /// <remarks> The DisplayStyleSetType defines a collection of display style types.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DisplayStyleSetType : ArrayBaseType<DisplayStyleType>
    {
        /// <remarks> Each DisplayStyle element defines a display style.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DisplayStyle")]
        public DisplayStyleType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
