/*! \file ZoneDataSetType.cs
    \brief ZoneDataSetType collects information about one or more tolerance zones.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The ZoneDataSetType collects information about one or more tolerance zones.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneDataSetType : ArrayBaseType<ZoneDataType>
    {
        /// <remarks> Each ZoneData element gives information about a single tolerance zone.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ZoneData")]
        public ZoneDataType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The ZoneDataType defines a tolerance zone.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ZoneDataType
    {
        /// <remarks> The FeatureItemId element is the QIF id of a feature item reference for zone data.</remarks>
        public Primitives.QIFReferenceType FeatureItemId { get; set; }

        /// <remarks> The Bonus element is the size of the bonus to the tolerance zone.</remarks>
        public LinearValueType Bonus { get; set; }

        /// <remarks> The ReferenceLength element is the length of the tolerance zone.</remarks>
        public LinearValueType ReferenceLength { get; set; }
    }
}
