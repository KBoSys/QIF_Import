/*! \file FaceBaseType.cs
	\brief abstract base type for faces.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The FaceBaseType is the abstract base type for faces. 
    /// A face represents a bounded portion of a geometric surface which can be
    /// defined as a parametric surface or a mesh surface.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceMeshType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FaceBaseType : TopologyBaseType
    {
        /// <remarks> The optional Validation element is a set of face validation properties.</remarks>
        public ValidationFaceType Validation { get; set; }

        /// <remarks> The optional turned attribute shows if the face
        /// orientation must be reversed from the orientation
        /// of the underlying surface.If the value is true, the face
        /// orientation must be opposite the surface orientation.
        /// If the value is false, the two orientations must be the same.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("turned")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Turned { get; set; } = false;
    }

    /// <remarks> The FaceMeshType is the b-rep mesh face type. It is built on a mesh
    /// surface bounded by a set of closed triangulation paths(polylines
    /// formed from the triangle edges).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FaceMeshType : FaceBaseType
    {
        /// <remarks> The Mesh element is the identifier of the underlying mesh surface.</remarks>
        public ElementReferenceType Mesh { get; set; }

        /// <remarks> The optional LoopIds element is an array of identifiers of
        /// the face trimming contours.If the hasOuter attribute is
        /// true then the first id will point to the outer loop
        /// otherwise all ids will point to inner loops only.</remarks>
        public ArrayReferenceType? LoopIds { get; set; }

        /// <remarks> This optional compositor provides a choice of the
        /// representation method for the face interior - a manifold
        /// sub-set of triangles of the underlying mesh surface bounded by the face loops.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Triangles", typeof(ArrayIntType))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesBinary", typeof(ArrayBinaryType))]
        public object? Triangles { get; set; }

        /// <remarks> This optional compositor provides a choice of the
        /// representation method for the visibility flags of the face interior triangles.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("TrianglesHidden", typeof(ArrayIntType))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesHiddenBinary", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesVisible", typeof(ArrayIntType))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesVisibleBinary", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("VisibilityElementName")]
        public object? Visibility { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public FaceMeshVisibilityChoiceType VisibilityElementName { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("TrianglesColor", typeof(ArrayUnsignedByteType))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesColorBinary", typeof(ArrayBinaryType))]
        public object? Item2 { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum FaceMeshVisibilityChoiceType
    {
        /// <remarks></remarks>
        TrianglesHidden,

        /// <remarks></remarks>
        TrianglesHiddenBinary,

        /// <remarks></remarks>
        TrianglesVisible,

        /// <remarks></remarks>
        TrianglesVisibleBinary,
    }

    /// <remarks> The FaceType is the b-rep face type - a bounded portion of a surface.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FaceType : FaceBaseType
    {
        /// <remarks> The Surface element is the identifier of the underlying surface.</remarks>
        public ElementReferenceType Surface { get; set; }

        /// <remarks> The optional LoopIds element is an array of identifiers of
        /// the face trimming contours.If the hasOuter attribute is true then the first id will point to the outer loop
        /// otherwise all ids will point to inner loops only.</remarks>
        public ArrayReferenceType? LoopIds { get; set; }

        /// <remarks> The optional hasOuter attribute shows if the face has its
        /// outer loop explicitly represented in the loop array.
        /// If this attribute is false, the natural border of the underlying
        /// surface must be taken as the face outer loop.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("hasOuter")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool HasOuter { get; set; } = true;
    }

    /// <remarks> The ValidationFaceType defines a set of face validation properties.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ValidationFaceType
    {
        /// <remarks> The optional Area element is the face area.</remarks>
        public double Area { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AreaSpecified { get; set; }

        /// <remarks> The optional Centroid element is the face center of mass.</remarks>
        public PointSimpleType? Centroid { get; set; }

        /// <remarks> The optional Box element is the face bounding box.</remarks>
        public BoundingBoxAxisAlignedType Box { get; set; }

        /// <remarks> The optional ValidationPointsType is a set of points that lie on the face.</remarks>
        public ValidationPointsType Points { get; set; }
    }
}
