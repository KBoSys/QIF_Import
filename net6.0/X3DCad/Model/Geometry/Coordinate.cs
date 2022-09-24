/*! \file Coordinate.cs
	\brief This node defines a set of 3D coordinates to be used in the coord field of vertex-based geometry

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// This node defines a set of 3D coordinates to be used in the coord field of vertex-based geometry
    /// </summary>
    public class Coordinate : X3DCoordinateNode
    {
        [XmlIgnore]
        public MFVec3f Point { get; set; } = new MFVec3f();

        [XmlAttribute("point")]
        public string? PointAsText 
        { 
            get => Point.ToString();
            set => Point.FromString(value);
        }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("coord")]
        public string? Container { get; set; }
    }
}
