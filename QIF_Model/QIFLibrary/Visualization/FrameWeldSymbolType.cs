/*! \file FrameWeldSymbolType.cs
	\brief defines the frame of a weld symbol.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The FrameWeldSymbolType defines the frame of a weld symbol./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameWeldSymbolType : FrameBaseType
    {
        /// <remarks The ReferenceLineBeginPoint element is the begin point of the reference line./>
        public Point2dSimpleType ReferenceLineBeginPoint { get; set; }

        /// <remarks The ReferenceLineEndPoint element is the end point of the reference line./>
        public Point2dSimpleType ReferenceLineEndPoint { get; set; }

        /// <remarks The optional Tail element gives the tail of the weld symbol frame./>
        public FrameWeldSymbolTailType Tail { get; set; }

        /// <remarks The optional MainSymbol element gives a main symbol. It can be omitted for a weld symbol with multiple reference lines./>
        public WeldMainSymbolType MainSymbol { get; set; }

        /// <remarks The optional SupplementarySymbol element gives a supplementary symbol./>
        public WeldSupplementarySymbolType SupplementarySymbol { get; set; }

        /// <remarks The optional ArrowSideContourSymbol element gives a contour symbol to be placed on the arrow side of the reference line./>
        public WeldContourSymbolType ArrowSideContourSymbol { get; set; }

        /// <remarks The optional OtherSideContourSymbol element gives a contour symbol to be placed on the other side of the reference line./>
        public WeldContourSymbolType OtherSideContourSymbol { get; set; }
    }

    /// <remarks The FrameWeldSymbolTailType defines the tail of a weld symbol frame./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameWeldSymbolTailType
    {
        /// <remarks The UpperPoint element defines the upper point of the tail./>
        public Point2dSimpleType UpperPoint { get; set; }

        /// <remarks The LowerPoint element defines the lower point of the tail./>
        public Point2dSimpleType LowerPoint { get; set; }
    }
}
