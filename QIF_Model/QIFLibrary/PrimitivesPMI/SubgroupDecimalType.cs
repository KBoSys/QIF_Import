/*! \file SubgroupDecimalType.cs
    \brief defines an MeasuredDecimalType associated with a particular subgroup id.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks A SubgroupDecimalType defines an MeasuredDecimalType associated with a particular subgroup id./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupDecimalType : MeasuredDecimalType
    {
        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The required subgroupId attribute references the id of the subgroup with which this decimal value is associated./>
        [System.Xml.Serialization.XmlAttribute("subgroupId")]
        public uint SubgroupId { get => this.QIFID; set => this.QIFID = value; }
    }
}
