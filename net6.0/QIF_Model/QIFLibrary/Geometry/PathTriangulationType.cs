/*! \file PathTriangulationType.cs
	\brief defines a triangulation path (polylines formed from the triangle edges).

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks> The PathTriangulationType defines a triangulation path (polylines formed from the triangle edges).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PathTriangulationType : GeometryBaseType
    {
        /// <remarks> The PathTriangulationCore element defines the mathematical core of this curve type.</remarks>
        public PathTriangulationCoreType? PathTriangulationCore { get; set; }

        /// <remarks> The MeshTriangle element is the identifier of a triangle mesh.</remarks>
        public ElementReferenceType? MeshTriangle { get; set; }
    }

    /// <remarks> The PathTriangulationCoreType defines the mathematical core of the
    /// triangulation path(a polyline formed from the triangle edges).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PathTriangulationCoreType
    {
        /// <remarks> This compositor provides a choice of the representation method for the triangulation path.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Edges", typeof(ArrayI2Type))]
        [System.Xml.Serialization.XmlElementAttribute("EdgesBinary", typeof(ArrayBinaryType))]
        public object? Item { get; set; }
    }
}
