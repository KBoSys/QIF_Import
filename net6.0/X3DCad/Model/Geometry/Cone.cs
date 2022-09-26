/*! \file Cone.cs
	\brief Specifies a cone which is centred in the local coordinate system and whose central axis is aligned with the local Y-axis.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The Cone node specifies a cone which is centred in the local coordinate system and whose central axis is aligned with the local Y-axis.
    /// </summary>
    public class Cone : Geometry3DBase
    {
        [XmlAttribute("bottom")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Bottom { get; set; } = true;

        [XmlAttribute("bottomRadius")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float BottomRadius { get; set; } = 1;

        [XmlAttribute("height")]
        [System.ComponentModel.DefaultValueAttribute(2)]
        public float Height { get; set; } = 2;

        [XmlAttribute("side")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Side { get; set; } = true;
    }
}
