/*! \file SubgroupsType.cs
    \brief defines a list of id subgroups.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The SubgroupsType defines a list of id subgroups.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupsType : ArrayBaseType<SubgroupType>
    {
        /// <remarks> Each Subgroup element contains a list of the characteristic
        /// measurement ids used in a subgroup in this statistical evaluation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Subgroup")]
        public SubgroupType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The SubgroupType defines a list of characteristics contained in a subgroup and assigns an id for referencing.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupType
    {
        /// <remarks> The MeasuredIds element contains a list of ids of the
        /// characteristic measurements used in this subgroup and an
        /// optional set of exclusions from the list.</remarks>
        public StatsArrayIdType MeasuredIds { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The required id attribute is the QIF id of the assignable cause, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }
}
