/*! \file X3DLightNode.cs
	\brief Light nodes provide illumination for rendering geometry in the scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Types;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Light nodes provide illumination for rendering geometry in the scene.
    /// Implementing nodes must include a global field with type SFBool and accessType inputOutput.
    /// </summary>
    public abstract class X3DLightNode : X3DChildNode
    {
        #region Fields
        private unitIntervalType ambientIntensity = new unitIntervalType(0);
        private unitIntervalType shadowIntensity = new unitIntervalType(1);

        [XmlIgnore]
        public SFColor Color { get; set; } = new SFColor(1, 1, 1);
        #endregion Fields

        #region XML Serialization
        [XmlAttribute("ambientIntensity")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public float AmbientIntensity { get => ambientIntensity; set => ambientIntensity = value; }

        [XmlAttribute("color")]
        [System.ComponentModel.DefaultValueAttribute("1 1 1")]
        public string? ColorAsText { get => Color.ToString(); set => Color.FromString(value); }

        [XmlAttribute("intensity")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float Intensity { get; set; } = 1;

        [XmlAttribute("on")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool On { get; set; } = true;

        [XmlAttribute("shadows")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Shadows { get; set; } = false;

        [XmlAttribute("shadowIntensity")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float ShadowIntensity { get => shadowIntensity; set => shadowIntensity = value; }
        #endregion XML Serialization
    }
}
