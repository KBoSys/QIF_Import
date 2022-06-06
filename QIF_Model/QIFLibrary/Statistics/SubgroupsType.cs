/*! \file SubgroupsType.cs
    \brief defines a list of id subgroups.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The SubgroupsType defines a list of id subgroups./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupsType
    {
        /// <remarks Each Subgroup element contains a list of the characteristic
        /// measurement ids used in a subgroup in this statistical evaluation./>
        [System.Xml.Serialization.XmlElementAttribute("Subgroup")]
        public SubgroupType[] Subgroups { get; set; }

        /// <remarks The required n attribute is the number of subgroups in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Subgroups.Length;
            set { }
        }
    }

    /// <remarks The SubgroupType defines a list of characteristics contained in a subgroup and assigns an id for referencing./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupType
    {
        /// <remarks The MeasuredIds element contains a list of ids of the
        /// characteristic measurements used in this subgroup and an
        /// optional set of exclusions from the list./>
        public StatsArrayIdType MeasuredIds { get; set; }

        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The required id attribute is the QIF id of the assignable cause, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }
}
