/*! \file Cylinder.cs
	\brief The Cylinder node specifies a capped cylinder centred at (0,0,0) in the local coordinate system and with a central axis oriented along the local Y-axis. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The Cylinder node specifies a capped cylinder centred at (0,0,0) in the local coordinate system and with a central axis oriented along the local Y-axis. 
    /// By default, the cylinder is sized at "-1" to "+1" in all three dimensions. The radius field specifies the radius of the cylinder and the height field 
    /// specifies the height of the cylinder along the central axis. Both radius and height shall be greater than zero. Figure 13.3 illustrates the Cylinder node.
    /// The cylinder has three parts: the side, the top(Y = +height / 2) and the bottom(Y = −height/2). Each part has an associated SFBool field that indicates 
    /// whether the part exists(TRUE) or does not exist(FALSE). 
    /// Parts which do not exist are not rendered and not eligible for intersection tests(EXAMPLE collision detection or sensor activation).
    /// </summary>
    public class Cylinder : X3DGeometryNode
    {
        [XmlAttribute("bottom")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Bottom { get; set; } = true;

        [XmlAttribute("height")]
        [System.ComponentModel.DefaultValueAttribute(2)]
        public float Height { get; set; } = 2;

        [XmlAttribute("radius")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float Radius { get; set; } = 1;

        [XmlAttribute("side")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Side { get; set; } = true;

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Solid { get; set; } = true;

        [XmlAttribute("top")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Top { get; set; } = true;

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }
}
