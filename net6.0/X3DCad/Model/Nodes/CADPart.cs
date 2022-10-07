/*! \file CADPart.cs
	\brief CADPart implements X3DGroupingNode but can only contain CADFace or ProtoInstance nodes

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
    /// CADPart implements X3DGroupingNode but can only contain CADFace or ProtoInstance nodes
    /// </summary>
    public class CADPart : X3DProductStructureChildNode
    {
        #region Properties
        [XmlIgnore]
        public SFVec3f? Center { get; set; }

        [XmlIgnore]
        public SFRotation? Rotation { get; set; }

        [XmlIgnore]
        public SFVec3f? Scale { get; set; }

        [XmlIgnore]
        public SFRotation? ScaleOrientation { get; set; }

        [XmlIgnore]
        public SFVec3f? Translation { get; set; }

        [XmlIgnore]
        public SFVec3f? BboxCenter { get; set; }

        [XmlIgnore]
        public bboxSizeType? BboxSize { get; set; }
        #endregion

        #region Serialization
        [XmlElement("CADFace", typeof(CADFace))]
        [XmlElement("Transform", typeof(Transform))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public List<object> Children { get; set; } = new List<object>();

        [XmlAttribute("center")]
        public string? CenterText { get => Center?.ToString(); set => Center = SFVec3f.CreateFromString(value); }

        [XmlAttribute("rotation")]
        public string? RotationText { get => Rotation?.ToString(); set => Rotation = SFRotation.CreateFromString(value); }

        [XmlAttribute("scale")]
        public string? ScaleText { get => Scale?.ToString(); set => SFVec3f.CreateFromString(value); }

        [XmlAttribute("scaleOrientation")]
        public string? ScaleOrientationText { get => ScaleOrientation?.ToString(); set => ScaleOrientation = SFRotation.CreateFromString(value); }

        [XmlAttribute("translation")]
        public string? TranslationText { get => Translation?.ToString(); set => Translation = SFVec3f.CreateFromString(value); }

        [XmlAttribute("bboxCenter")]
        public string? BboxCenterText { get => BboxCenter?.ToString(); set => BboxCenter = SFVec3f.CreateFromString(value); }

        [XmlAttribute("bboxSize")]
        public string? BboxSizeText { get => BboxSize?.ToString(); set => BboxSize = bboxSizeType.CreateFromString(value); }

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
