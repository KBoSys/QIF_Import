/*! \file Circle2D.cs
	\brief The Circle2D node specifies a circle centred at (0,0) in the local 2D coordinate system.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The Circle2D node specifies a circle centred at (0,0) in the local 2D coordinate system.
    /// </summary>
    public class Circle2D : GeometryBase
    {
        public Circle2D()
        {
        }
        public Circle2D(float r)
        {
            Radius = r;
        }

        [XmlAttribute("radius")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float Radius { get; set; } = 1;
    }
}
