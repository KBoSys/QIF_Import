/*! \file PointCloudSetType.cs
	\brief Represents a container for storing all model point clouds.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The PointCloudSetType represents a container for storing all model point clouds.</remarks>
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointCloudSetType : ArrayBaseType<PointCloudType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("PointCloud")]
        public PointCloudType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
