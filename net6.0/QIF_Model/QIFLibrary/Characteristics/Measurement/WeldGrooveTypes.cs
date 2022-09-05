/*! \file WeldGrooveTypes.cs
    \brief Defines Weld Groove Types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The LocationSignificanceOneSidesEnumType enumerates values that describe one side location significance.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LocationSignificanceOneSidesEnumType
    {
        /// <remarks></remarks>
        ARROW_SIDE,

        /// <remarks></remarks>
        OTHER_SIDE,
    }

    /// <remarks> The WeldSupplementarySymbolEnumType enumerates values that describe
    /// the supplementary symbol for a one-sided groove weld characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum WeldSupplementarySymbolEnumType
    {
        /// <remarks></remarks>
        BACK_WELD,

        /// <remarks></remarks>
        MELT_THROUGH,

        /// <remarks></remarks>
        CONSUMABLE_INSERT,

        /// <remarks></remarks>
        REMOVABLE_BACKING,
    }


    /// <remarks> The WeldGrooveOneSideType describes a one-sided groove weld characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveOneSideType
    {
        /// <remarks> The LocationSignificance element specifies the location significance of the characteristic.</remarks>
        public LocationSignificanceOneSidesEnumType LocationSignificance { get; set; }

        /// <remarks> The optional SideParameters element specifies weld parameters.</remarks>
        public WeldGrooveOneSideParametersType? SideParameters { get; set; }

        /// <remarks> The optional SupplementarySymbol element specifies a supplementary symbol.</remarks>
        public WeldSupplementarySymbolEnumType SupplementarySymbol { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupplementarySymbolSpecified { get; set; }
    }

    /// <remarks> The WeldGrooveBothSidesBaseType describes a two-sided groove weld characteristic.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldGrooveBothSidesExtendedType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveBothSidesBaseType
    {
        /// <remarks> The optional SideParameters element specifies weld parameters
        /// on the arrow side of the reference line.</remarks>
        public WeldGrooveOneSideParametersType? ArrowSideParameters { get; set; }

        /// <remarks> The optional SideParameters element specifies weld parameters
        /// on the other side of the reference line.</remarks>
        public WeldGrooveOneSideParametersType? OtherSideParameters { get; set; }
    }

    /// <remarks> The WeldGrooveBothSidesExtendedType describes a two-sided
    /// groove weld characteristic that can use a spacer in the joint.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveBothSidesExtendedType : WeldGrooveBothSidesBaseType
    {
        /// <remarks> The optional Spacer element indicates the use of a spacer in the joint.</remarks>
        public bool Spacer { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpacerSpecified { get; set; }
    }
}
