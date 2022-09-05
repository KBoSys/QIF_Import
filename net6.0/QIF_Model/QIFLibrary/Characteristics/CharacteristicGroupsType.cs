/*! \file CharacteristicGroupsType.cs
    \brief defines a list of characteristic groups. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using System;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <summary>
    /// The CharacteristicGroupsType defines a list of characteristic groups.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicGroupsType : ArrayBaseType<CharacteristicGroupType>
    {
        /// <remarks> Each CharacteristicGroup element gives information about a
        /// characteristic group.It is a way of relating characteristics
        /// based on common association.e.g.manufacturing, process, print callout.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicGroup", typeof(CharacteristicGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicManufacturingProcessGroup", typeof(CharacteristicManufacturingProcessGroupType))]
        public CharacteristicGroupType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <summary>
    /// The CharacteristicGroupType defines a group of characteristics. In
    /// addition to being reported together, the group may be also be
    /// transformed into a new space or may undergo a change of units.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CharacteristicManufacturingProcessGroupType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CharacteristicGroupType
    {
        /// <remarks> The CharacteristicItemIds element gives a list of ids of the characteristic items in the group.</remarks>
        public Primitives.ArrayReferenceType? CharacteristicItemIds { get; set; }

        /// <remarks> The optional Description element is a text description of the characteristic group.</remarks>
        public string? Description { get; set; }

        /// <remarks> The optional Name element is the name of the characteristic group.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string? Name { get; set; }

        /// <remarks> The optional TransformId element is the QIF id of a transform
        /// to be used for reporting.All nominal and measured data in the
        /// characteristic group will be transformed by the referenced transformation matrix. </remarks>
        public Primitives.QIFReferenceType? TransformId { get; set; }

        /// <remarks> The optional Units element specifies the units used for reporting the characteristic group.</remarks>
        public Units.OtherUnitsType? Units { get; set; }

        /// <remarks> The optional Scale element specifies the scaling factors and direction for reporting the characteristic group.</remarks>
        public PrimitivesPMI.ScaleType? Scale { get; set; }

        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public Primitives.AttributesType? Attributes { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; } = new QIFApplications.QIFIdType();

        [System.Xml.Serialization.XmlAttribute("id")]
        public UInt32 Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks> The CharacteristicManufacturingProcessGroupType defines a group of characteristics associated with a particular manufacturing process.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CharacteristicManufacturingProcessGroupType : CharacteristicGroupType
    {
        /// <remarks> The optional ManufacturingProcessId element is a
        /// reference to the traceability information for process used to manufacture this group of characteristics.</remarks>
        public Primitives.QIFReferenceType? ManufacturingProcessId { get; set; }
    }

    /// <remarks> The CharacteristicGroupStatusesType defines a list of characteristic group statuses.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicGroupStatusesType : ArrayBaseType<CharacteristicGroupStatusType>
    {
        /// <remarks> Each CharacteristicGroupStatus element gives information about the inspection status of a characteristic group.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicGroupStatus")]
        public CharacteristicGroupStatusType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The CharacteristicGroupStatusType defines a post inspection status of a characteristic group.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicGroupStatusType
    {
        /// <remarks> The Status element is the characteristic condition for the characteristic group as a whole.</remarks>
        public CharacteristicStatusType? Status { get; set; }

        /// <remarks> The GroupId element is the QIF id of the characteristic group to which the status applies.</remarks>
        public Primitives.QIFReferenceFullType? GroupId { get; set; }
    }

    /// <remarks> The CharacteristicStatusType defines the status of a characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicStatusType
    {
        /// <remarks> This compositor provides a choice between the characteristic
        /// status as an enumeration of a common type and a user defined
        /// string that describes the characteristic status.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicStatusEnum", typeof(CharacteristicStatusEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCharacteristicStatus", typeof(string))]
        public object? Item { get; set; }
    }

    /// <remarks> The CharacteristicStatusEnumType enumerates values that describe
    /// the status of a characteristic: in conformance PASS, out of
    /// conformance FAIL, or several other possible statuses.
    /// ISO theoretically exact dimensions(TED) and ASME basic
    /// dimensions are analogous concepts both of which are signified with the BASIC_OR_TED enumeration.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CharacteristicStatusEnumType
    {

        /// <remarks></remarks>
        PASS,

        /// <remarks></remarks>
        FAIL,

        /// <remarks></remarks>
        REWORK,

        /// <remarks></remarks>
        SYSERROR,

        /// <remarks></remarks>
        INDETERMINATE,

        /// <remarks></remarks>
        NOT_ANALYZED,

        /// <remarks></remarks>
        BASIC_OR_TED,

        /// <remarks></remarks>
        UNDEFINED,
    }

}