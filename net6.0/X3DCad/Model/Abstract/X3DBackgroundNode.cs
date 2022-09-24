/*! \file X3DBackgroundNode.cs
	\brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Nodes;

namespace X3DCad.Model.Abstract
{
    [XmlInclude(typeof(Background))]
    public abstract class X3DBackgroundNode : X3DNodeBase
    {
        [XmlAttribute("groundAngle")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public float GroundAngle { get; set; } = 0.0f;

        [XmlAttribute("groundColor")]
        public string? GroundColor { get; set; }

        [XmlAttribute("skyAngle")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public float SkyAngle { get; set; } = 0.0f;

        [XmlAttribute("skyColor")]
        public string? SkyColor { get; set; }

        [XmlAttribute("transparency")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public float Transparency { get; set; } = 0.0f;
    }
}
