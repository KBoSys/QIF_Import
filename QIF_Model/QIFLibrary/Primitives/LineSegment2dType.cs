/*! \file LineSegment2dType.cs
	\brief defines a portion of a 2D line defined and bounded by a start point and an end point.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks> The LineSegment2dType defines a portion of a 2D line defined and bounded by a start point and an end point.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineSegment2dType
    {
        #region ref="LineSegment2dGroup"
        /// <remarks> The StartPoint element is the beginning point of the 2D line segment.</remarks>
        public Point2dSimpleType StartPoint { get; set; }

        /// <remarks> The EndPoint element is the ending point of the 2D line segment.</remarks>
        public Point2dSimpleType EndPoint { get; set; }
        #endregion
    }
}
