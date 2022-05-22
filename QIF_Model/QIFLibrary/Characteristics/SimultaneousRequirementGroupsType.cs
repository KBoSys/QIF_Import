/*! \file SimultaneousRequirementGroupsType.cs
    \brief defines a list of simultaneous requirement groups. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <summary>
    /// The SimultaneousRequirementGroupsType defines a list of simultaneous requirement groups.
    /// </summary>
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SimultaneousRequirementGroupsType
    {

        /// <remarks Each SimultaneousRequirementGroup element gives information
        /// about a simultaneous requirement group.It is a way of
        /// explicitly grouping characteristics that share a simultaneous requirement./>
        [System.Xml.Serialization.XmlElementAttribute("SimultaneousRequirementGroup")]
        public SimultaneousRequirementGroupType[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The SimultaneousRequirementGroupType defines a group of characteristics that share a simultaneity requirement./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SimultaneousRequirementGroupType
    {
        /// <remarks The CharacteristicNominalIds element gives a list of ids of
        /// the characteristic nominals in the simultaneous requirement group./>
        public Primitives.ArrayReferenceType CharacteristicNominalIds { get; set; }

        /// <remarks The Requirement element defines the simultaneous requirement for the group of characteristics./>
        public SimultaneousRequirementEnumType Requirement { get; set; }

        /// <remarks The optional CompositeLevel element defines the composite level to which the simultaneous requirement applies./>
        public CompositeSegmentLowerLevelEnumType CompositeLevel { get; set; }
    }

    /// <remarks The SimultaneousRequirementEnumType enumerates values that describe a simultaneous requirement./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SimultaneousRequirementEnumType
    {
        SEP_REQ, /// <remarks/>
        SIM_REQ, /// <remarks/>
    }

    /// <remarks The CompositeSegmentLevelEnumType enumerates values that describe a lower level of a composite characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CompositeSegmentLowerLevelEnumType
    {
        SECOND, /// <remarks/>
        THIRD,  /// <remarks/>
        FOURTH, /// <remarks/>
        FIFTH,  /// <remarks/>
    }
}
