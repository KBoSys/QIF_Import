/*! \file ExplodedViewType.cs
	\brief defines a sequence of translate and rotate operations

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
    /// <remarks The ExplodedViewType defines a sequence of translate and rotate
    /// operations that is applied to the groups of components and bodies.
    /// The exploded view shows each object separated from others./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewType : NodeWithIdBaseType
    {
        /// <remarks/>
        public ExplodedViewMoveGroupsType MoveGroups { get; set; }
    }

    /// <remarks The ExplodedViewMoveGroupsType defines a sequence of translate and
    /// rotate operations that is applied to the groups of components and bodies./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewMoveGroupsType
    {
        /// <remarks Each MoveGroup element is a group of components and bodies with a defined translate or rotate operator./>
        [System.Xml.Serialization.XmlElementAttribute("MoveGroup")]
        public ExplodedViewMoveGroupType[] Items { get; set; }

        /// <remarks The required n attribute is the number of elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The ExplodedViewMoveGroupType is a group of components and bodies
    /// with a defined translate or rotate operation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewMoveGroupType
    {
        /// <remarks 
        /// The Translate element alternative is the translation operator of the group.
        /// The Rotate element alternative is the rotation operator of the group./>
        [System.Xml.Serialization.XmlElementAttribute("Rotate", typeof(ExplodedViewRotateType))]
        [System.Xml.Serialization.XmlElementAttribute("Translate", typeof(ExplodedViewTranslateType))]
        public object Item { get; set; }

        /// <remarks The optional ComponentIds element is an array of component identifiers./>
        public ArrayReferenceFullType ComponentIds { get; set; }

        /// <remarks The optional BodyIds element is an array of body identifiers./>
        public ArrayReferenceFullType BodyIds { get; set; }
    }

    /// <remarks The ExplodedViewRotateType defines the rotation of the group in the exploded view./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewRotateType
    {
        /// <remarks The Axis element is the rotation axis./>
        public AxisType Axis { get; set; }

        /// <remarks The Angle element is the rotation angle./>
        public AngularValueType Angle { get; set; }
    }

    /// <remarks The ExplodedViewTranslateType defines the translation of the group in the exploded view./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewTranslateType
    {
        /// <remarks The Direction element is the translation direction./>
        public UnitVectorType Direction { get; set; }

        /// <remarks The Value element is the translation distance./>
        public LinearValueType Value { get; set; }
    }

    /// <remarks The ExplodedViewSetType defines a collection of exploded views./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExplodedViewSetType
    {
        /// <remarks Each ExplodedView element defines an exploded view./>
        [System.Xml.Serialization.XmlElementAttribute("ExplodedView")]
        public ExplodedViewType[] Items { get; set; }

        /// <remarks The required n attribute is the number of exploded views in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
