/*! \file TrailingZeroDisplayType.cs
	\brief defines trailing zero display options to be used in characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The TrailingZeroDisplayType defines trailing zero display options to be used in characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TrailingZeroDisplayType
    {
        /// <remarks The optional DimensionalCharacteristicValueTarget element shows
        /// whether all value targets in dimensional characteristics displayed with(true) or without(false) trailing zeros.
        /// If this element not defined then the display of trailing zeros uses the definition in the standard./>
        public bool DimensionalCharacteristicValueTarget { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionalCharacteristicValueTargetSpecified { get; set; }

        /// <remarks The optional DimensionalCharacteristicValueLimits element shows
        /// whether all value limits in dimensional characteristics displayed with(true) or without(false) trailing zeros.
        /// If this element not defined then the display of trailing zeros uses the definition in the standard./>
        public bool DimensionalCharacteristicValueLimits { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionalCharacteristicValueLimitsSpecified { get; set; }

        /// <remarks The optional GeometricCharacteristicValue element shows whether
        /// all value in geometric characteristics displayed with(true) or without(false) trailing zeros.
        /// If this element not defined then the display of trailing zeros uses the definition in the standard./>
        public bool GeometricCharacteristicValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GeometricCharacteristicValueSpecified { get; set; }

        /// <remarks The optional TrailingZeroDimensionalCharacteristicDisplayGroups
        /// element contains groups of dimensional characteristics with defined trailing zero display options./>
        public TrailingZeroDimensionalCharacteristicDisplayGroupsType TrailingZeroDimensionalCharacteristicDisplayGroups { get; set; }

        /// <remarks The optional TrailingZeroGeometricCharacteristicDisplayGroups
        /// element contains groups of dimensional characteristics with defined trailing zero display options./>
        public TrailingZeroGeometricCharacteristicDisplayGroupsType TrailingZeroGeometricCharacteristicDisplayGroups { get; set; }
    }

    /// <remarks The TrailingZeroDimensionalCharacteristicDisplayGroupsType is a
    /// collection of groups of dimensional characteristics with defined trailing zero display options./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TrailingZeroDimensionalCharacteristicDisplayGroupsType
    {
        /// <remarks Each TrailingZeroDimensionalCharacteristicGroup element is a
        /// group of dimensional characteristics with defined trailing zero display options./>
        [System.Xml.Serialization.XmlElementAttribute("TrailingZeroDimensionalCharacteristicDisplayGroup")]
        public TrailingZeroDimensionalCharacteristicDisplayGroupType[] Items { get; set; }

        /// <remarks The required n attribute is the number of elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The TrailingZeroGeometricCharacteristicDisplayGroupsType is a
    /// collection of groups of geometric characteristics with defined trailing zero display options./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TrailingZeroGeometricCharacteristicDisplayGroupsType
    {
        /// <remarks Each TrailingZeroGeometricCharacteristicGroup element is a
        /// group of geometric characteristics with defined trailing zero display options./>
        [System.Xml.Serialization.XmlElementAttribute("TrailingZeroGeometricCharacteristicDisplayGroup")]
        public TrailingZeroGeometricCharacteristicDisplayGroupType[] Items { get; set; }

        /// <remarks The required n attribute is the number of elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The TrailingZeroDimensionalCharacteristicDisplayGroupType defines
    /// the trailing zero display options for a group of dimensional characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TrailingZeroDimensionalCharacteristicDisplayGroupType
    {
        /// <remarks The optional DimensionalCharacteristicValueTarget element shows
        /// whether all value targets in dimensional characteristics are
        /// displayed with(true) or without(false) trailing zeros./>
        public bool DimensionalCharacteristicValueTarget { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionalCharacteristicValueTargetSpecified { get; set; }

        /// <remarks The optional DimensionalCharacteristicValueLimits element shows
        /// whether all value limits in dimensional characteristics are displayed with(true) or without(false) trailing zeros./>
        public bool DimensionalCharacteristicValueLimits { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionalCharacteristicValueLimitsSpecified { get; set; }

        /// <remarks The DimensionalCharacteristicIds element is an array of dimensional characteristics identifiers./>
        public ArrayReferenceFullType DimensionalCharacteristicIds { get; set; }
    }

    /// <remarks The TrailingZeroGeometricCharacteristicDisplayGroupType defines the
    /// trailing zero display options for a group of geometric characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TrailingZeroGeometricCharacteristicDisplayGroupType
    {
        /// <remarks The optional GeometricCharacteristicValue element shows whether
        /// all value in geometric characteristics are displayed with(true) or without(false) trailing zeros./>
        public bool GeometricCharacteristicValue { get; set; }

        /// <remarks The GeometricCharacteristicIds element is an array of geometric characteristics identifiers./>
        public ArrayReferenceFullType GeometricCharacteristicIds { get; set; }
    }
}
