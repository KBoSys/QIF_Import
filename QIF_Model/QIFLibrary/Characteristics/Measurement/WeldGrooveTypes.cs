/*! \file WeldGrooveTypes.cs
    \brief Defines Weld Groove Types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The LocationSignificanceOneSidesEnumType enumerates values that describe one side location significance./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LocationSignificanceOneSidesEnumType
    {
        /// <remarks/>
        ARROW_SIDE,

        /// <remarks/>
        OTHER_SIDE,
    }

    /// <remarks The WeldSupplementarySymbolEnumType enumerates values that describe
    /// the supplementary symbol for a one-sided groove weld characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum WeldSupplementarySymbolEnumType
    {
        /// <remarks/>
        BACK_WELD,

        /// <remarks/>
        MELT_THROUGH,

        /// <remarks/>
        CONSUMABLE_INSERT,

        /// <remarks/>
        REMOVABLE_BACKING,
    }


    /// <remarks The WeldGrooveOneSideType describes a one-sided groove weld characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveOneSideType
    {
        /// <remarks The LocationSignificance element specifies the location significance of the characteristic./>
        public LocationSignificanceOneSidesEnumType LocationSignificance { get; set; }

        /// <remarks The optional SideParameters element specifies weld parameters./>
        public WeldGrooveOneSideParametersType SideParameters { get; set; }

        /// <remarks The optional SupplementarySymbol element specifies a supplementary symbol./>
        public WeldSupplementarySymbolEnumType SupplementarySymbol { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupplementarySymbolSpecified { get; set; }
    }

    /// <remarks The WeldGrooveBothSidesBaseType describes a two-sided groove weld characteristic./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldGrooveBothSidesExtendedType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveBothSidesBaseType
    {
        /// <remarks The optional SideParameters element specifies weld parameters
        /// on the arrow side of the reference line./>
        public WeldGrooveOneSideParametersType ArrowSideParameters { get; set; }

        /// <remarks The optional SideParameters element specifies weld parameters
        /// on the other side of the reference line./>
        public WeldGrooveOneSideParametersType OtherSideParameters { get; set; }
    }

    /// <remarks The WeldGrooveBothSidesExtendedType describes a two-sided
    /// groove weld characteristic that can use a spacer in the joint./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveBothSidesExtendedType : WeldGrooveBothSidesBaseType
    {
        /// <remarks The optional Spacer element indicates the use of a spacer in the joint./>
        public bool Spacer { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpacerSpecified { get; set; }
    }
}
