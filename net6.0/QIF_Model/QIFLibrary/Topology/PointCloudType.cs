/*! \file PointCloudType.cs
    \brief describes a set of 3D points with optional normals.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The PointCloudType describes a set of 3D points with optional normals.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointCloudType : TopologyBaseType
    {
        /// <remarks> This compositor provides a choice of the representation method for an array of 3D points.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Points", typeof(ArrayPointType))]
        [System.Xml.Serialization.XmlElementAttribute("PointsBinary", typeof(ArrayBinaryType))]
        public object? Points { get; set; }

        /// <remarks> This optional compositor provides a choice of the representation method for an array of normals.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Normals", typeof(ArrayUnitVectorType))]
        [System.Xml.Serialization.XmlElementAttribute("NormalsBinary", typeof(ArrayBinaryType))]
        public object? Normals { get; set; }

        /// <remarks> This optional compositor provides a choice of the
        /// representation method for the visibility flags of the points.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("PointsHidden", typeof(ArrayIntType))]
        [System.Xml.Serialization.XmlElementAttribute("PointsHiddenBinary", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("PointsVisible", typeof(ArrayIntType))]
        [System.Xml.Serialization.XmlElementAttribute("PointsVisibleBinary", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("VisibilityElementName")]
        public object? Visibility { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public PointsVisibilityChoiceType VisibilityElementName { get; set; }

        /// <remarks> This optional compositor provides a choice of the representation method for the color property of the points.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("PointsColor", typeof(ArrayUnsignedByteType))]
        [System.Xml.Serialization.XmlElementAttribute("PointsColorBinary", typeof(ArrayBinaryType))]
        public object? PointsColor { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum PointsVisibilityChoiceType
    {
        /// <remarks></remarks>
        PointsHidden,

        /// <remarks></remarks>
        PointsHiddenBinary,

        /// <remarks></remarks>
        PointsVisible,

        /// <remarks></remarks>
        PointsVisibleBinary,
    }
}
