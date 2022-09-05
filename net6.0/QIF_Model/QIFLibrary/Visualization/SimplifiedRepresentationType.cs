/*! \file SimplifiedRepresentationType.cs
	\brief defines a simplified model representation to be used in a saved view.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Characteristics;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The SimplifiedRepresentationType defines a simplified model representation to be used in a saved view.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimplifiedRepresentationType : NodeWithIdBaseType
    {
        /// <remarks></remarks>
        public SimplifiedRepresentationFormEnumType Form { get; set; }

        /// <remarks></remarks>
        public SimplifiedRepresentationGroupsType? SimplifiedRepresentationGroups { get; set; }
    }

    /// <remarks> The SimplifiedRepresentationFormEnumType enumerates values that describe simplified representation forms.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SimplifiedRepresentationFormEnumType
    {
        /// <remarks></remarks>
        MASTER,

        /// <remarks></remarks>
        HIDE,

        /// <remarks></remarks>
        BOUNDING_BOX,
    }

    /// <remarks> The SimplifiedRepresentationGroupsType is a collection of groups of components and bodies with defined simplified representation forms.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimplifiedRepresentationGroupsType : ArrayBaseType<SimplifiedRepresentationGroupType>
    {
        /// <remarks> Each SimplifiedRepresentationGroup element is a group of
        /// components and bodies with defined simplified representation forms.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SimplifiedRepresentationGroup")]
        public SimplifiedRepresentationGroupType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The SimplifiedRepresentationGroupType defines a simplified representation for a group of components and bodies.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimplifiedRepresentationGroupType
    {
        /// <remarks> The Form element is a simplified representation form.</remarks>
        public SimplifiedRepresentationFormEnumType Form { get; set; }

        /// <remarks> The optional ComponentIds element is an array of component identifiers.</remarks>
        public ArrayReferenceFullType? ComponentIds { get; set; }

        /// <remarks> The optional BodyIds element is an array of body identifiers.</remarks>
        public ArrayReferenceFullType? BodyIds { get; set; }
    }

    /// <remarks> The SimplifiedRepresentationSetType defines a collection of simplified representations.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimplifiedRepresentationSetType : ArrayBaseType<SimplifiedRepresentationType>
    {
        /// <remarks> Each SimplifiedRepresentation element defines a simplified representation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SimplifiedRepresentation")]
        public SimplifiedRepresentationType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
