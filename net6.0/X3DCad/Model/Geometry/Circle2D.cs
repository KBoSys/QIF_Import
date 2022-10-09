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

        /// <summary>
        /// The radius of the circle
        /// </summary>
        [XmlAttribute("radius")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float Radius { get; set; } = 1;
    }

    /// <summary>
    /// The Arc node specifies a linear circular arc whose center is at (0,0) and whose angles are measured starting at the positive x-axis and sweeping towards the positive y-axis.
    /// </summary>
    public class Arc2D : Circle2D
    {
        /// <summary>
        /// The arc extends from the startAngle counterclockwise to the endAngle. 
        /// The values of startAngle and endAngle shall be in the range [-2π, 2π] radians (or the equivalent if a different angle base unit has been specified). 
        /// If startAngle and endAngle have the same value, a circle is specified.
        /// </summary>
        [XmlAttribute("startAngle")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public float StartAngle { get; set; } = 0;

        [XmlAttribute("endAngle")]
        [System.ComponentModel.DefaultValueAttribute(1.570796f)]
        public float EndAngle { get; set; } = 1.570796f;
    }

    /// <summary>
    /// closureTypeChoices are strictly allowed enumeration values for ArcClose2D closureType field. This list is bounded, no additional values are allowed.
    /// </summary>
    public enum ClosureTypeChoices
    {
        /// <summary>
        /// Connects arc endpoints to center, forming a pie wedge
        /// </summary>
        PIE,

        /// <summary>
        /// Connects arc endpoints directly to each other, as in chord on a circle
        /// </summary>
        CHORD
    }

    /// <summary>
    /// The ArcClose2D node specifies surface geometry describing a portion of a circle, 
    /// whose center is at (0,0) and whose angles are measured starting at the positive x-axis and sweeping towards the positive y-axis
    /// </summary>
    public class ArcClose2D : Arc2D
    {
        [XmlAttribute("closureType")]
        [System.ComponentModel.DefaultValueAttribute(ClosureTypeChoices.PIE)]
        public ClosureTypeChoices ClosureType { get; set; } = ClosureTypeChoices.PIE;

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Solid { get; set; } = false;
    }
}