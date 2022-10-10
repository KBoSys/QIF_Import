/*! \file Rectangle2D.cs
	\brief Specifies a rectangle centred at (0, 0) in the current local 2D coordinate system and aligned with the local coordinate axes. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The Rectangle2D node specifies a rectangle centred at (0, 0) in the current local 2D coordinate system and aligned with the local coordinate axes. 
    /// By default, the box measures 2 units in each dimension, from -1 to +1.
    /// </summary>
    public class Rectangle2D : GeometryBase
    {
        /// <summary>
        /// The size field specifies the extents of the box along the X- axis and Y-axis respectively, and each component value shall be greater than zero. 
        /// </summary>
        [XmlIgnore]
        public SFVec2f Size { get; set; } = new SFVec2f(2, 2);

        [XmlAttribute("size")]
        [System.ComponentModel.DefaultValueAttribute("2 2")]
        public string? SizeAsText { get => Size.ToString(); set => Size.FromString(value); }
    }
}
