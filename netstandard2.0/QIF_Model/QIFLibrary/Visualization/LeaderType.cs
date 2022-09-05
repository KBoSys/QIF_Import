/*! \file LeaderType.cs
	\brief defines a 3D annotation leader.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The LeaderType defines a 3D annotation leader.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LeaderCircularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LeaderDoubleHeadType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LeaderDoubleHeadCircularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LeaderDoubleHeadExtendType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LeaderExtendType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LeaderType : LineSegment2dType
    {
        /// <remarks> The HeadForm element gives the form of the leader head.</remarks>
        public LeaderHeadFormType HeadForm { get; set; }

        /// <remarks> The HeadHeight element is the size of the leader head.</remarks>
        public double HeadHeight { get; set; }
    }

    /// <remarks> The LeaderCircularType defines a leader that is a circular arc which is less than a semicircle.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LeaderCircularType : LeaderType
    {
        /// <remarks> The Center element specifies the 2D coordinates of the
        /// leader central point.The 2D coordinates are defined in the
        /// visualization plane coordinate system.</remarks>
        public Point2dSimpleType Center { get; set; }
    }

    /// <remarks> The LeaderDoubleHeadType defines a double headed leader.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LeaderDoubleHeadCircularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LeaderDoubleHeadExtendType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LeaderDoubleHeadType : LeaderType
    {
        /// <remarks> The HeadForm2 element defines the second head form.</remarks>
        public LeaderHeadFormEnumType HeadForm2 { get; set; }

        /// <remarks> The PointConnection specifies 2D coordinates of the connection point.
        /// The 2D coordinates are defined in the visualization plane coordinate system.</remarks>
        public Point2dSimpleType PointConnection { get; set; }
    }

    /// <remarks> The LeaderDoubleHeadCircularType defines a double headed circular leader.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LeaderDoubleHeadCircularType : LeaderDoubleHeadType
    {
        /// <remarks> The Center element specifies the 2D coordinates of the second central point.
        /// The 2D coordinates are defined in the visualization plane coordinate system.</remarks>
        public Point2dSimpleType Center { get; set; }
    }

    /// <remarks> The LeaderDoubleHeadExtendType defines a double headed extended leader which has a break point and consists of two segments.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LeaderDoubleHeadExtendType : LeaderDoubleHeadType
    {
        /// <remarks> The PointExtension element specifies 2D coordinates of the extension point.
        /// The 2D coordinates are defined in the visualization plane coordinate system.</remarks>
        public Point2dSimpleType PointExtension { get; set; }
    }

    /// <remarks> The LeaderExtendType defines an extended leader which has a break point and consists of two segments.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LeaderExtendType : LeaderType
    {
        /// <remarks> The PointExtension element specifies the 2D coordinates of the extension point.
        /// The 2D coordinates are defined in the visualization plane coordinate system.</remarks>
        public Point2dSimpleType PointExtension { get; set; }

        /// <remarks> The optional Modifier element specifies a leader modifier.</remarks>
        public LeaderModifierEnumType Modifier { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifierSpecified { get; set; }
    }

    /// <remarks> The LeaderModifierEnumType enumerates values that describe the leader's modifier.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LeaderModifierEnumType
    {
        /// <remarks></remarks>
        ALL_AROUND,

        /// <remarks></remarks>
        ALL_OVER,

        /// <remarks></remarks>
        FLAG,

        /// <remarks></remarks>
        ALL_AROUND_FLAG,
    }

    /// <remarks> The LeaderHeadFormType defines the form of a leader head.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LeaderHeadFormType
    {
        private D3Type normalField;

        /// <remarks> The optional normal attribute defines the normal of the plane for drawing a leader head with type SYMBOL_CROSS.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("normal")]
        public double[] Normal { get => normalField; set => normalField = value; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public LeaderHeadFormEnumType Value { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LeaderHeadFormEnumType
    {
        /// <remarks></remarks>
        NONE,

        /// <remarks></remarks>
        ARROW_OPEN,

        /// <remarks></remarks>
        ARROW_UNFILLED,

        /// <remarks></remarks>
        ARROW_BLANKED,

        /// <remarks></remarks>
        ARROW_FILLED,

        /// <remarks></remarks>
        TRIANGLE_BLANKED,

        /// <remarks></remarks>
        TRIANGLE_FILLED,

        /// <remarks></remarks>
        DOT_BLANKED,

        /// <remarks></remarks>
        DOT_FILLED,

        /// <remarks></remarks>
        BOX_BLANKED,

        /// <remarks></remarks>
        BOX_FILLED,

        /// <remarks></remarks>
        DIMENSION_ORIGIN,

        /// <remarks></remarks>
        SYMBOL_SLASH,

        /// <remarks></remarks>
        SYMBOL_INTEGRAL,

        /// <remarks></remarks>
        SYMBOL_CROSS,
    }

}
