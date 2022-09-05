/*! \file SurfaceMeshSetType.cs
	\brief Represents a container for storing all mesh surfaces present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks> The SurfaceMeshSetType represents a container for storing all mesh surfaces present in the CAD scene.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceMeshSetType : ArrayBaseType<MeshTriangleType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("MeshTriangle")]
        public MeshTriangleType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}