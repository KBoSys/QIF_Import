/*! \file Extrusion.cs
	\brief Specifies geometric shapes based on a two dimensional cross-section extruded along a three dimensional spine in the local coordinate system. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The Extrusion node specifies geometric shapes based on a two dimensional cross-section extruded along a three dimensional spine in the local coordinate system. 
    /// The cross-section can be scaled and rotated at each spine point to produce a wide variety of shapes.
    /// </summary>
    public class Extrusion : GeometryBase
    {
        #region Constructor
        public Extrusion()
        {
            CrossSection = new MFVec2f();
            CrossSection.FromString("1 1 1 -1 -1 -1 -1 1 1 1");

            Orientation = new MFRotation();
            Orientation.Add(new SFRotation());

            Scale = new MFVec2f();
            Scale.Add(new SFVec2f(1, 1));

            Spine = new MFVec3f();
            Spine.FromString("0 0 0 0 1 0");
        }
        #endregion

        #region Properties
        [XmlIgnore]
        public MFVec2f CrossSection { get; set; }

        [XmlIgnore]
        public MFRotation Orientation { get; set; }

        [XmlIgnore]
        public MFVec2f Scale { get; set; }

        [XmlIgnore]
        public MFVec3f Spine { get; set; }
        #endregion

        #region Xml Serialization
        [XmlAttribute("beginCap")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool BeginCap { get; set; } = true;

        [XmlAttribute("ccw")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool CCW { get; set; } = true;

        [XmlAttribute("convex")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Convex { get; set; } = true;

        [XmlAttribute("creaseAngle")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public float CreaseAngle { get; set; } = 0;

        [XmlAttribute("crossSection")]
        [System.ComponentModel.DefaultValueAttribute("1 1 1 -1 -1 -1 -1 1 1 1")]
        public string? CrossSectionAsText { get => CrossSection.ToString(); set => CrossSection.FromString(value); }

        [XmlAttribute("endCap")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool EndCap { get; set; } = true;

        [XmlAttribute("orientation")]
        [System.ComponentModel.DefaultValueAttribute("0 0 1 0")]
        public string? OrientationAsText { get => Orientation.ToString(); set => Orientation.FromString(value); }

        [XmlAttribute("scale")]
        [System.ComponentModel.DefaultValueAttribute("1 1")]
        public string? ScaleAsText { get => Scale.ToString(); set => Scale.FromString(value); }

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Solid { get; set; } = true;

        [XmlAttribute("spine")]
        [System.ComponentModel.DefaultValueAttribute("0 0 0 0 1 0")]
        public string? SpineAsText { get => Spine.ToString(); set => Spine.FromString(value); }
        #endregion
    }
}
