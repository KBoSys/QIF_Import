/*! \file VertexSetType.cs
	\brief a container for storing all model vertices.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks The VertexSetType represents a container for storing all model vertices./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VertexSetType
    {
        /// <remarks Each Vertex element is a model vertex./>
        [System.Xml.Serialization.XmlElementAttribute("Vertex")]
        public VertexType[] Vertices { get; set; }

        /// <remarks The required n attribute is the number of vertices in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Vertices.Length;
            set { }
        }
    }
}
