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

namespace X3DCad.Model.Abstract
{
    public abstract class X3DBackgroundNode
    {
        [XmlAttribute("groundAngle")]
        public float GroundAngle { get; set; }

        [XmlAttribute("groundColor")]
        public string? GroundColor { get; set; }

        [XmlAttribute("skyAngle")]
        public float SkyAngle { get; set; }

        [XmlAttribute("skyColor")]
        public string? SkyColor { get; set; }

        [XmlAttribute("transparency")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public float Transparency { get; set; }
    }
}
