﻿/*! \file AuxiliaryBaseType.cs
	\brief abstract base type for all auxiliary object types.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Auxiliary
{
    /// <remarks> The AuxiliaryBaseType is the abstract base type for all auxiliary object types.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryPlaneBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneReferenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineAuxiliaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointAuxiliaryType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class AuxiliaryBaseType : DrawableBaseType
    {
    }

    /// <remarks> The AuxiliaryPlaneBaseType is the abstract base type for all auxiliary plane types.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class AuxiliaryPlaneBaseType : AuxiliaryBaseType
    {
        /// <remarks> The Plane element is the plane definition.</remarks>
        public PlaneType? Plane { get; set; }
    }

    /// <remarks> The PlaneReferenceType defines a plane with user defined attributes
    /// and direct references; the plane may be used as an auxiliary plane.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneReferenceType : AuxiliaryPlaneBaseType
    {
    }

    /// <remarks> The LineAuxiliaryType defines an auxiliary line.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineAuxiliaryType : AuxiliaryBaseType
    {
        /// <remarks> The LineSegmentGroup is a group of elements that contains a start point and an end point that define a portion of a line.</remarks>
        #region ref="LineSegmentGroup"
        /// <remarks> The StartPoint element is the beginning point of the line segment.</remarks>
        public PointSimpleType? StartPoint { get; set; } = new PointSimpleType();

        /// <remarks> The EndPoint element is the ending point of the line segment.</remarks>
        public PointSimpleType? EndPoint { get; set; } = new PointSimpleType();
        #endregion

        /// <remarks></remarks>
        public LineStyleType LineStyle { get; set; } = new LineStyleType();
    }

    /// <remarks> The PointAuxiliaryType defines an auxiliary point.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointAuxiliaryType : AuxiliaryBaseType
    {
        /// <remarks> The XYZ element is the Cartesian three-dimensional coordinates of the 3D point.</remarks>
        public PointType? XYZ { get; set; } = new PointType();
    }
}
