/*! \file VertexSetType.cs
	\brief a container for storing all model vertices.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The VertexSetType represents a container for storing all model vertices.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VertexSetType : ArrayBaseType<VertexType>
    {
        /// <remarks> Each Vertex element is a model vertex.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Vertex")]
        public VertexType[] Vertices { get => base.itemsField; set => base.itemsField = value; }
    }
}
