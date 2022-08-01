/*! \file ShellSetType.cs
	\brief a container for storing all model shells.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks The ShellSetType represents a container for storing all model shells./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ShellSetType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Shell")]
        public ShellType[] Items { get; set; }

        /// <remarks The required n attribute is the number of shels in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
