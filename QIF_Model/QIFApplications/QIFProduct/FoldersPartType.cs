/*! \file FoldersPartType.cs
	\brief defines a folder tree of a part.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks> The FolderPartType is the part folder type. It contains a set of entities that define the part.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FolderPartType : FolderPartAssemblyBaseType
    {
    }

    /// <remarks> The FoldersPartType defines a folder tree of a part.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FoldersPartType
    {
        /// <remarks> Each FolderPart element is a folder of a part.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FolderPart")]
        public FolderPartType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of the FolderPart elements in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
