/*! \file AuxiliarySetType.cs
	\brief Represents a container for storing all auxiliary objects present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Auxiliary
{
    /// <remarks> The AuxiliarySetType represents a container for storing all auxiliary objects present in the CAD scene.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AuxiliarySetType
    {
        /// <remarks> Each Auxiliary element is an auxiliary object.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("PointAuxiliary", typeof(PointAuxiliaryType))]
        [System.Xml.Serialization.XmlElementAttribute("LineAuxiliary", typeof(LineAuxiliaryType))]
        [System.Xml.Serialization.XmlElementAttribute("PlaneReference", typeof(PlaneReferenceType))]
        public AuxiliaryBaseType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of auxiliary objects in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
