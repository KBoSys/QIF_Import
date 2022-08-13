/*! \file FramesType.cs
	\brief defines an array of visualization frames.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The FramesType defines an array of visualization frames./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FramesType
    {
        /// <remarks Each Frame element is a visualization frame./>
        [System.Xml.Serialization.XmlElementAttribute("FrameRectangular", typeof(FrameRectangularType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameCircular", typeof(FrameCircularType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameFlag", typeof(FrameFlagType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameIrregularForm", typeof(FrameIrregularFormType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameTriangle", typeof(FrameTriangleType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameHexagonal", typeof(FrameHexagonalType))]
        [System.Xml.Serialization.XmlElementAttribute("FramePentagonal", typeof(FramePentagonalType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameOctagonal", typeof(FrameOctagonalType))]
        [System.Xml.Serialization.XmlElementAttribute("FrameWeldSymbol", typeof(FrameWeldSymbolType))]
        public FrameBaseType[] Frames { get; set; }

        /// <remarks The required n attribute is the number of visualization frames in this array./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Frames.Length;
            set { }
        }
    }

    /// <remarks The FrameBaseType is the abstract base type for all frame types./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameHexagonalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameOctagonalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FramePentagonalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameTriangleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameWeldSymbolType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameIrregularFormType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameCircularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameRectangularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameFlagType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FrameBaseType
    {
    }

    /// <remarks a base class for frames defined by 2D polyline/>
    public abstract class FramePolylineBaseType : FrameBaseType
    {
        /// <remarks Each Point element is a point of a hexagonal 2D polyline
        /// which describes the frame shape. The 2D coordinates of the
        /// polyline point are defined in the visualization plane coordinate system./>
        [System.Xml.Serialization.XmlElementAttribute("Point")]
        public Point2dSimpleType[] Points { get; set; }
    }

    /// <remarks The FrameHexagonalType defines a hexagonal frame./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameHexagonalType : FramePolylineBaseType
    {
    }

    /// <remarks The FrameOctagonalType defines an octagonal frame./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameOctagonalType : FramePolylineBaseType
    {
    }

    /// <remarks The FramePentagonalType defines a pentagonal frame./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FramePentagonalType : FramePolylineBaseType
    {
    }

    /// <remarks The FrameTriangleType defines a triangular frame./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameTriangleType : FramePolylineBaseType
    {
    }

    /// <remarks The FrameIrregularFormType defines an irregular form frame./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameIrregularFormType : FrameBaseType
    {
        /// <remarks/>
        public ArrayPoint2dType Points { get; set; }
    }

    /// <remarks The FrameCircularType defines a circular frame. This is normally used for visualization of datum targets./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameCircularType : FrameBaseType
    {
        /// <remarks The XY element specifies the 2D coordinates of the anchor point.
        /// The 2D coordinates are defined in the visualization plane coordinate system./>
        public Point2dSimpleType XY { get; set; }

        /// <remarks The Radius element is the frame radius./>
        public double Radius { get; set; }

        /// <remarks The optional crossed attribute shows if the frame must be
        /// crossed with the middle line which separates the circular frame in two halves(top and bottom)./>
        [System.Xml.Serialization.XmlAttributeAttribute("crossed")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Crossed { get; set; } = true;
    }

    /// <remarks The FrameRectangularType defines a rectangular frame./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrameFlagType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameRectangularType : FrameBaseType
    {
        /// <remarks The XY element specifies the 2D coordinates of the anchor point.
        /// The 2D coordinates are defined in the visualization plane coordinate system./>
        public Point2dSimpleType XY { get; set; }

        /// <remarks The Width element is the frame width./>
        public double Width { get; set; }

        /// <remarks The Height element is the frame height./>
        public double Height { get; set; }
    }

    /// <remarks The FrameFlagType defines a flag frame. This is normally used for visualization of flag notes./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FrameFlagType : FrameRectangularType
    {
        /// <remarks The optional right attribute shows if the flag frame has the triangle element at the right side./>
        [System.Xml.Serialization.XmlAttributeAttribute("right")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Right { get; set; }
    }
}
