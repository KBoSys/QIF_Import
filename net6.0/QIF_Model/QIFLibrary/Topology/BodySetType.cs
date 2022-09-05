/*! \file BodySetType.cs
	\brief a container for storing all model bodies.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The BodySetType represents a container for storing all model bodies.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BodySetType : ArrayBaseType<BodyType>
    {
        /// <remarks> Each Body element is a model body.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Body")]
        public BodyType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
