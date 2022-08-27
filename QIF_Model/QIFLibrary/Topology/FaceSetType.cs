/*! \file FaceSetType.cs
	\brief a container for storing all model faces.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The FaceSetType represents a container for storing all model faces.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FaceSetType
    {
        /// <remarks> Each FaceBase element represents one face. The face may be parametric(Face) or mesh(FaceMesh).</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Face", typeof(FaceType))]
        [System.Xml.Serialization.XmlElementAttribute("FaceMesh", typeof(FaceMeshType))]
        public FaceBaseType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of faces in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
