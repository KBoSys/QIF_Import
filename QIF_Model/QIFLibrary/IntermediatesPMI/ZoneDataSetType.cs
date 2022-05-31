/*! \file ZoneDataSetType.cs
    \brief ZoneDataSetType collects information about one or more tolerance zones.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The ZoneDataSetType collects information about one or more tolerance zones./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneDataSetType
    {
        /// <remarks Each ZoneData element gives information about a single tolerance zone./>
        [System.Xml.Serialization.XmlElementAttribute("ZoneData")]
        public ZoneDataType[] Items { get; set; }

        /// <remarks The required n attribute is the number of tolerance zones in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The ZoneDataType defines a tolerance zone./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneDataType
    {
        /// <remarks The FeatureItemId element is the QIF id of a feature item reference for zone data./>
        public Primitives.QIFReferenceType FeatureItemId { get; set; }

        /// <remarks The Bonus element is the size of the bonus to the tolerance zone./>
        public LinearValueType Bonus { get; set; }

        /// <remarks The ReferenceLength element is the length of the tolerance zone./>
        public LinearValueType ReferenceLength { get; set; }
    }
}
