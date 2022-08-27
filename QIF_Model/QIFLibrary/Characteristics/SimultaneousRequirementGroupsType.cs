/*! \file SimultaneousRequirementGroupsType.cs
    \brief defines a list of simultaneous requirement groups. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <summary>
    /// The SimultaneousRequirementGroupsType defines a list of simultaneous requirement groups.
    /// </summary>
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SimultaneousRequirementGroupsType
    {

        /// <remarks> Each SimultaneousRequirementGroup element gives information
        /// about a simultaneous requirement group.It is a way of
        /// explicitly grouping characteristics that share a simultaneous requirement.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SimultaneousRequirementGroup")]
        public SimultaneousRequirementGroupType[] Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks> The SimultaneousRequirementGroupType defines a group of characteristics that share a simultaneity requirement.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SimultaneousRequirementGroupType
    {
        /// <remarks> The CharacteristicNominalIds element gives a list of ids of
        /// the characteristic nominals in the simultaneous requirement group.</remarks>
        public Primitives.ArrayReferenceType CharacteristicNominalIds { get; set; }

        /// <remarks> The Requirement element defines the simultaneous requirement for the group of characteristics.</remarks>
        public SimultaneousRequirementEnumType Requirement { get; set; }

        /// <remarks> The optional CompositeLevel element defines the composite level to which the simultaneous requirement applies.</remarks>
        public CompositeSegmentLowerLevelEnumType CompositeLevel { get; set; }
    }

    /// <remarks> The SimultaneousRequirementEnumType enumerates values that describe a simultaneous requirement.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SimultaneousRequirementEnumType
    {
        SEP_REQ, /// <remarks></remarks>
        SIM_REQ, /// <remarks></remarks>
    }

    /// <remarks> The CompositeSegmentLevelEnumType enumerates values that describe a lower level of a composite characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CompositeSegmentLowerLevelEnumType
    {
        SECOND, /// <remarks></remarks>
        THIRD,  /// <remarks></remarks>
        FOURTH, /// <remarks></remarks>
        FIFTH,  /// <remarks></remarks>
    }
}
