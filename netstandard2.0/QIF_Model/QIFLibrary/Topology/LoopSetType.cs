/*! \file LoopSetType.cs
	\brief a container for storing all model loops.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The LoopSetType represents a container for storing all model loops.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LoopSetType : ArrayBaseType<LoopBaseType>
    {
        /// <remarks> Each LoopBase element is a model loop.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Loop", typeof(LoopType))]
        [System.Xml.Serialization.XmlElementAttribute("LoopMesh", typeof(LoopMeshType))]
        public LoopBaseType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
