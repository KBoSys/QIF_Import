/*! \file EdgeSetType.cs
	\brief a container for storing all model edges.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks The EdgeSetType represents a container for storing all model edges./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EdgeSetType
    {
        /// <remarks Each Edge element is a model edge./>
        [System.Xml.Serialization.XmlElementAttribute("Edge")]
        public EdgeType[] Edges { get; set; }

        /// <remarks The required n attribute is the number of edges in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Edges.Length;
            set { }
        }
    }
}
