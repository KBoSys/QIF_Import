/*! \file PointCloudSetType.cs
	\brief Represents a container for storing all model point clouds.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The PointCloudSetType represents a container for storing all model point clouds.</remarks>
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointCloudSetType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("PointCloud")]
        public PointCloudType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of point clouds in this set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
