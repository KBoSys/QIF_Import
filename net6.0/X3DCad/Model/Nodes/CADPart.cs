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
        #region public Properties
        [XmlIgnore]
        public SFVec3f Center { get; set; } = new SFVec3f();

        [XmlIgnore]
        public SFRotation Rotation { get; set; } = new SFRotation();

        [XmlIgnore]
        public SFVec3f Scale { get; set; } = new SFVec3f(1, 1, 1);

        [XmlIgnore]
        public SFRotation ScaleOrientation { get; set; } = new SFRotation();

        [XmlIgnore]
        public SFVec3f Translation { get; set; } = new SFVec3f();

        [XmlIgnore]
        public SFVec3f BboxCenter { get; set; } = new SFVec3f();

        [XmlIgnore]
        public bboxSizeType BboxSize { get; set; } = new bboxSizeType();
        #endregion

        #region Serialization
        [XmlElement("CADFace", typeof(CADFace))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object[]? Children { get; set; }

        [XmlAttribute("center")]
        public string? CenterText { get => Center.ToString(); set => Center.FromString(value); }

        [XmlAttribute("rotation")]
        public string? RotationText { get => Rotation.ToString(); set => Rotation.FromString(value); }

        [XmlAttribute("scale")]
        public string? ScaleText { get => Scale.ToString(); set => Scale.FromString(value); }

        [XmlAttribute("scaleOrientation")]
        public string? ScaleOrientationText { get => ScaleOrientation.ToString(); set => ScaleOrientation.FromString(value); }

        [XmlAttribute("translation")]
        public string? TranslationText { get => Translation.ToString(); set => Translation.FromString(value); }

        [XmlAttribute("bboxCenter")]
        public string? BboxCenterText { get => BboxCenter.ToString(); set => BboxCenter.FromString(value); }

        [XmlAttribute("bboxSize")]
        public string? BboxSizeText { get => BboxSize.ToString(); set => BboxSize.FromString(value); }

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
