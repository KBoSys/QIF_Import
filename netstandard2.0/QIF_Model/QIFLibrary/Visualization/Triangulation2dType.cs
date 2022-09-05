/*! \file Triangulation2dType.cs
	\brief defines a 2D triangle mesh.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The Triangulation2dType defines a 2D triangle mesh.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Triangulation2dType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Vertices", typeof(ArrayPoint2dType))]
        [System.Xml.Serialization.XmlElementAttribute("VerticesBinary", typeof(ArrayBinaryType))]
        public object Vertices { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Triangles", typeof(ArrayI3Type))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesBinary", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesColor", typeof(ArrayUnsignedByteType))]
        [System.Xml.Serialization.XmlElementAttribute("TrianglesColorBinary", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("TrianglesElementName")]
        public object Triangles { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TrianglesChoiceType TrianglesElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum TrianglesChoiceType
    {
        /// <remarks></remarks>
        Triangles,

        /// <remarks></remarks>
        TrianglesBinary,

        /// <remarks></remarks>
        TrianglesColor,

        /// <remarks></remarks>
        TrianglesColorBinary,
    }

}
