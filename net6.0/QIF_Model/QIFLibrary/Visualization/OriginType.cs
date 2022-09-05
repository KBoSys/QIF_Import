/*! \file OriginType.cs
	\brief defines the origin of a 2D element.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Characteristics.Measurement;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The OriginType defines the origin of a 2D element.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldContourSymbolType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSupplementarySymbolType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldMainSymbolType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class OriginType
    {
        /// <remarks> The Origin element is the 2D position.</remarks>
        public Point2dSimpleType? Origin { get; set; }
    }

    /// <remarks> The WeldMainSymbolType defines a main symbol placed on the reference line of the weld symbol.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldMainSymbolType : OriginType
    {
        /// <remarks> The Symbol element gives the symbol to be placed on the reference line.</remarks>
        public WeldMainSymbolEnumType Symbol { get; set; }
    }

    /// <remarks> The WeldContourSymbolType defines a contour symbol of the weld symbol.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldContourSymbolType : OriginType
    {
        /// <remarks> The Symbol element gives a contour symbol.</remarks>
        public WeldContourSymbolEnumType Symbol { get; set; }
    }

    /// <remarks> The WeldSupplementarySymbolType defines a supplementary symbol of the weld symbol.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSupplementarySymbolType : OriginType
    {
        /// <remarks> The Symbol element defines a supplementary symbol.</remarks>
        public WeldSupplementarySymbolEnumType Symbol { get; set; }
    }

    /// <remarks> The WeldMainSymbolEnumType enumerates values that describe the main symbol of the weld symbol object.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum WeldMainSymbolEnumType
    {
        /// <remarks></remarks>
        WELD_FILLET_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_FILLET_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_FILLET_BOTH,

        /// <remarks></remarks>
        WELD_SPOT_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_SPOT_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_SPOT_NO_SIDE,

        /// <remarks></remarks>
        WELD_STUD_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_SEAM_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_SEAM_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_SEAM_NO_SIDE,

        /// <remarks></remarks>
        WELD_SURFACING_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_EDGE_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_EDGE_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_SQUARE_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_SQUARE_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_SQUARE_BOTH,

        /// <remarks></remarks>
        WELD_V_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_V_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_V_BOTH,

        /// <remarks></remarks>
        WELD_BEVEL_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_BEVEL_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_BEVEL_BOTH,

        /// <remarks></remarks>
        WELD_U_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_U_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_U_BOTH,

        /// <remarks></remarks>
        WELD_J_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_J_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_J_BOTH,

        /// <remarks></remarks>
        WELD_FLARE_V_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_FLARE_V_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_FLARE_V_BOTH,

        /// <remarks></remarks>
        WELD_FLARE_BEVEL_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_FLARE_BEVEL_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_FLARE_BEVEL_BOTH,

        /// <remarks></remarks>
        WELD_SCARF_V_ARROW_SIDE,

        /// <remarks></remarks>
        WELD_SCARF_V_OTHER_SIDE,

        /// <remarks></remarks>
        WELD_SCARF_V_BOTH,

        /// <remarks></remarks>
        WELD_V_SPACER,

        /// <remarks></remarks>
        WELD_BEVEL_SPACER,

        /// <remarks></remarks>
        WELD_U_SPACER,

        /// <remarks></remarks>
        WELD_J_SPACER,

        /// <remarks></remarks>
        WELD_FLARE_V_SPACER,

        /// <remarks></remarks>
        WELD_FLARE_BEVEL_SPACER,

        /// <remarks></remarks>
        BACK_WELD,

        /// <remarks></remarks>
        MELT_THROUGH,

        /// <remarks></remarks>
        CONSUMABLE_INSERT,

        /// <remarks></remarks>
        REMOVABLE_BACKING,
    }
}
