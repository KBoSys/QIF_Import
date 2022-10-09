/*! \file Disk2D.cs
	\brief Specifies a circular disk which is centred at (0, 0) in the local coordinate system.

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
    /// The Disk2D node specifies a circular disk which is centred at (0, 0) in the local coordinate system.
    /// </summary>
    public class Disk2D : GeometryBase
    {
        /// <summary>
        /// The innerRadius field specifies the inner dimension of the Disk2D
        /// The value of innerRadius shall be greater than or equal to zero and less than or equal to outerRadius. 
        /// If innerRadius is zero, the Disk2D is completely filled. Otherwise, the area within the innerRadius forms a hole in the Disk2D. 
        /// If innerRadius is equal to outerRadius, a solid circular line shall be drawn using the current line properties.
        /// </summary>
        [XmlAttribute("innerRadius")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public float InnerRadius { get; set; } = 0;

        /// <summary>
        /// The outerRadius field specifies the radius of the outer dimension of the Disk2D
        /// The value of outerRadius shall be greater than zero. 
        /// </summary>
        [XmlAttribute("outerRadius")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float OuterRadius { get; set; } = 1;

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Solid { get; set; } = false;
    }
}
