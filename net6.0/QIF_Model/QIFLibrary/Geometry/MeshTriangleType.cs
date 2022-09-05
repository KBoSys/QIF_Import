/*! \file MeshTriangleType.cs
	\brief defines the math core of the triangle mesh entity.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks> The MeshTriangleType defines the math core of the triangle mesh entity. 
    /// It contains a set of triangles connected by their common edges.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeshTriangleType : GeometryBaseType
    {
        /// <remarks> The MeshTriangleCore element defines the mathematical core of this surface type.</remarks>
        public MeshTriangleCoreType? MeshTriangleCore { get; set; }

        /// <remarks>
        /// The NormalsSpecial element is an array of normal vectors specified on the triangle level.This array is an
        /// addition to the core mesh normal vectors and it allows to define different normal vectors in a common vertex for
        /// different triangles.This situation is typical for vertices of mesh feature lines.
        /// 
        /// The NormalsBinary element is a binary array of normal vectors specified on the triangle level.Each element of
        /// this array is a pentad consisting of:
        /// a 32-bit integer index of a triangle;
        /// an 8-bit integer index of a triangle vertex(0, 1 or 2);
        /// a triplet of real numbers(represented in accordance with the standard IEEE 754-2008) : 
        /// the X-component, the Y-component and the Z-component.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("NormalsSpecial", typeof(ArrayTriangleVertexNormalType))]
        [System.Xml.Serialization.XmlElementAttribute("NormalsSpecialBinary", typeof(ArrayBinaryType))]
        public object? Item { get; set; }
    }

    /// <remarks> The MeshTriangleCoreType defines the math core of the triangle mesh
    /// entity. It contains a set of triangles connected by their common edges.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeshTriangleCoreType
    {
        /// <remarks> This compositor provides a choice of the representation method for indices of the triangle vertices.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Triangles", typeof(ArrayI3Type))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesBinary", typeof(ArrayBinaryType))]
        public object? Triangles { get; set; }

        /// <remarks> This optional compositor provides a choice of the representation method for indices of the triangle neighbors.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Neighbours", typeof(ArrayI3Type))]
        [System.Xml.Serialization.XmlElementAttribute("NeighboursBinary", typeof(ArrayBinaryType))]
        public object? Neighbours { get; set; }

        /// <remarks> This compositor provides a choice of the representation method for the triangle vertices.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Vertices", typeof(ArrayPointType))]
        [System.Xml.Serialization.XmlElementAttribute("VerticesBinary", typeof(ArrayBinaryType))]
        public object? Vertices { get; set; }

        /// <remarks> This optional compositor provides a choice of the representation method for the mesh normals.
        /// The mesh normals are defined at the mesh vertices and represent normals to the surface being approximated by the mesh.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Normals", typeof(ArrayUnitVectorType))]
        [System.Xml.Serialization.XmlElementAttribute("NormalsBinary", typeof(ArrayBinaryType))]
        public object? Normals { get; set; }
    }

    /// <remarks> The ArrayTriangleVertexNormalType is an array of normal vectors specified in triangle vertices. </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayTriangleVertexNormalType : ArrayBaseType<TriangleVertexNormalType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("NormalSpecial")]
        public TriangleVertexNormalType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The TriangleVertexNormalType defines the normal vector specified in a triangle vertex.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TriangleVertexNormalType : UnitVectorType
    {
        private I2Type? vertexField;

        /// <remarks> The vertex attribute is a pair of non-negative integers, 
        /// where the first value is a triangle index and the second value is a vertex index.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("vertex")]
        public int[]? Vertex
        {
            get => this.vertexField?.Value;
            set => this.vertexField = new I2Type(value);
        }
    }
}
