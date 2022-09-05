/*! \file EdgeSetType.cs
	\brief a container for storing all model edges.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The EdgeSetType represents a container for storing all model edges.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EdgeSetType : ArrayBaseType<EdgeType>
    {
        /// <remarks> Each Edge element is a model edge.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Edge")]
        public EdgeType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
