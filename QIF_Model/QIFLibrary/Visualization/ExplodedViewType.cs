/*! \file ExplodedViewType.cs
	\brief defines a sequence of translate and rotate operations

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The ExplodedViewType defines a sequence of translate and rotate
    /// operations that is applied to the groups of components and bodies.
    /// The exploded view shows each object separated from others.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewType : NodeWithIdBaseType
    {
        /// <remarks></remarks>
        public ExplodedViewMoveGroupsType MoveGroups { get; set; }
    }

    /// <remarks> The ExplodedViewMoveGroupsType defines a sequence of translate and
    /// rotate operations that is applied to the groups of components and bodies.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewMoveGroupsType : ArrayBaseType<ExplodedViewMoveGroupType>
    {
        /// <remarks> Each MoveGroup element is a group of components and bodies with a defined translate or rotate operator.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MoveGroup")]
        public ExplodedViewMoveGroupType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The ExplodedViewMoveGroupType is a group of components and bodies
    /// with a defined translate or rotate operation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewMoveGroupType
    {
        /// <remarks> 
        /// The Translate element alternative is the translation operator of the group.
        /// The Rotate element alternative is the rotation operator of the group.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Rotate", typeof(ExplodedViewRotateType))]
        [System.Xml.Serialization.XmlElementAttribute("Translate", typeof(ExplodedViewTranslateType))]
        public object Item { get; set; }

        /// <remarks> The optional ComponentIds element is an array of component identifiers.</remarks>
        public ArrayReferenceFullType ComponentIds { get; set; }

        /// <remarks> The optional BodyIds element is an array of body identifiers.</remarks>
        public ArrayReferenceFullType BodyIds { get; set; }
    }

    /// <remarks> The ExplodedViewRotateType defines the rotation of the group in the exploded view.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewRotateType
    {
        /// <remarks> The Axis element is the rotation axis.</remarks>
        public AxisType Axis { get; set; }

        /// <remarks> The Angle element is the rotation angle.</remarks>
        public AngularValueType Angle { get; set; }
    }

    /// <remarks> The ExplodedViewTranslateType defines the translation of the group in the exploded view.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewTranslateType
    {
        /// <remarks> The Direction element is the translation direction.</remarks>
        public UnitVectorType Direction { get; set; }

        /// <remarks> The Value element is the translation distance.</remarks>
        public LinearValueType Value { get; set; }
    }

    /// <remarks> The ExplodedViewSetType defines a collection of exploded views.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewSetType : ArrayBaseType<ExplodedViewType>
    {
        /// <remarks> Each ExplodedView element defines an exploded view.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ExplodedView")]
        public ExplodedViewType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
