/*! \file CADFace.cs
	\brief The CADFace node holds the geometry representing a face of a part.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Types;

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// The CADFace node holds the geometry representing a face of a part.
    /// </summary>
    public class CADFace : X3DProductStructureChildNode
    {
        #region Properties
        [XmlIgnore]
        public SFVec3f BboxCenter { get; set; } = new SFVec3f();

        [XmlIgnore]
        public bboxSizeType BboxSizeType { get; set; } = new bboxSizeType();
        #endregion

        #region Serialization
        [XmlElement("Shape", typeof(Shape))]
        [XmlElement("LOD", typeof(LOD))]
        [XmlElement("Transform", typeof(Transform))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object? Item { get; set; }

        [XmlAttribute("bboxCenter")]
        public string? BboxCenterText { get => BboxCenter.ToString(); set => BboxCenter.FromString(value); }

        [XmlAttribute("bboxSize")]
        public string? BboxSizeText { get => BboxSizeType.ToString(); set => BboxSizeType.FromString(value); }

        [XmlAttribute("bboxDisplay")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool BboxDisplay { get; set; } = false;

        [XmlAttribute("visible")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Visible { get; set; } = true;

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
        #endregion
    }
}
