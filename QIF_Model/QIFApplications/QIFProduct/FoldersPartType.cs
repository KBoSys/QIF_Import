/*! \file FoldersPartType.cs
	\brief defines a folder tree of a part.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

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
    public partial class FoldersPartType : ArrayBaseType<FolderPartType>
    {
        /// <remarks> Each FolderPart element is a folder of a part.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FolderPart")]
        public FolderPartType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
