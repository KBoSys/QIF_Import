/*! \file ShellSetType.cs
	\brief a container for storing all model shells.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The ShellSetType represents a container for storing all model shells.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ShellSetType : ArrayBaseType<ShellType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Shell")]
        public ShellType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
