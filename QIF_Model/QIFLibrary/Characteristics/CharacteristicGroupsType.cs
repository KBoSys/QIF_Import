/*! \file CharacteristicGroupsType.cs
    \brief defines a list of characteristic groups. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

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
    public partial class CharacteristicGroupsType
    {
        /// <remarks Each CharacteristicGroup element gives information about a
        /// characteristic group.It is a way of relating characteristics
        /// based on common association.e.g.manufacturing, process, print callout./>
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicGroup", typeof(CharacteristicGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicManufacturingProcessGroup", typeof(CharacteristicManufacturingProcessGroupType))]
        public CharacteristicGroupType[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
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
        /// <remarks The CharacteristicItemIds element gives a list of ids of the characteristic items in the group./>
        public Primitives.ArrayReferenceType CharacteristicItemIds { get; set; }

        /// <remarks The optional Description element is a text description of the characteristic group./>
        public string Description { get; set; }

        /// <remarks The optional Name element is the name of the characteristic group./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Name { get; set; }

        /// <remarks The optional TransformId element is the QIF id of a transform
        /// to be used for reporting.All nominal and measured data in the
        /// characteristic group will be transformed by the referenced transformation matrix. />
        public Primitives.QIFReferenceType TransformId { get; set; }

        /// <remarks The optional Units element specifies the units used for reporting the characteristic group./>
        public Units.OtherUnitsType Units { get; set; }

        /// <remarks The optional Scale element specifies the scaling factors and direction for reporting the characteristic group./>
        public PrimitivesPMI.ScaleType Scale { get; set; }

        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public Primitives.AttributesType Attributes { get; set; }

        /// <remarks The id attribute is the QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks The CharacteristicManufacturingProcessGroupType defines a group of characteristics associated with a particular manufacturing process./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CharacteristicManufacturingProcessGroupType : CharacteristicGroupType
    {
        /// <remarks The optional ManufacturingProcessId element is a
        /// reference to the traceability information for process used to manufacture this group of characteristics./>
        public Primitives.QIFReferenceType ManufacturingProcessId { get; set; }
    }

    /// <remarks The CharacteristicGroupStatusesType defines a list of characteristic group statuses./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicGroupStatusesType
    {
        /// <remarks Each CharacteristicGroupStatus element gives information about the inspection status of a characteristic group./>
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicGroupStatus")]
        public CharacteristicGroupStatusType[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The CharacteristicGroupStatusType defines a post inspection status of a characteristic group./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicGroupStatusType
    {
        /// <remarks The Status element is the characteristic condition for the characteristic group as a whole./>
        public CharacteristicStatusType Status { get; set; }

        /// <remarks The GroupId element is the QIF id of the characteristic group to which the status applies./>
        public Primitives.QIFReferenceFullType GroupId { get; set; }
    }

    /// <remarks The CharacteristicStatusType defines the status of a characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicStatusType
    {
        /// <remarks This compositor provides a choice between the characteristic
        /// status as an enumeration of a common type and a user defined
        /// string that describes the characteristic status./>
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicStatusEnum", typeof(CharacteristicStatusEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCharacteristicStatus", typeof(string))]
        public object Item { get; set; }
    }

    /// <remarks The CharacteristicStatusEnumType enumerates values that describe
    /// the status of a characteristic: in conformance PASS, out of
    /// conformance FAIL, or several other possible statuses.
    /// ISO theoretically exact dimensions(TED) and ASME basic
    /// dimensions are analogous concepts both of which are signified with the BASIC_OR_TED enumeration./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CharacteristicStatusEnumType
    {

        /// <remarks/>
        PASS,

        /// <remarks/>
        FAIL,

        /// <remarks/>
        REWORK,

        /// <remarks/>
        SYSERROR,

        /// <remarks/>
        INDETERMINATE,

        /// <remarks/>
        NOT_ANALYZED,

        /// <remarks/>
        BASIC_OR_TED,

        /// <remarks/>
        UNDEFINED,
    }

}