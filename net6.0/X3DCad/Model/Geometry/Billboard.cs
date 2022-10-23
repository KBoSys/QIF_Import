/*! \file Billboard.cs
	\brief The Billboard node is a grouping node that transforms the coordinate system of its children so that the local Z-axis of the children turns to point at the viewer within the limitations of its rotational axis.

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
    /// The Billboard node is a grouping node that transforms the coordinate system of its children so that the local Z-axis of the children 
    /// turns to point at the viewer within the limitations of its rotational axis.
    /// </summary>
    public class Billboard : X3DGroupingNode
    {
        /// <summary>
        /// The axisOfRotation field specifies which axis to use to perform the rotation. This axis is defined in the local coordinate system.
        /// </summary>
        [XmlIgnore]
        public SFVec3f AxisOfRotation { get; set; } = new SFVec3f(0, 1, 0);

        [XmlAttribute("axisOfRotation", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("0 1 0")]
        public string? AxisOfRotationAsText 
        { 
            get => AxisOfRotation.ToString(); 
            set => AxisOfRotation.FromString(value); 
        }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("children")]
        public string? ContainerField { get; set; }
    }
}
