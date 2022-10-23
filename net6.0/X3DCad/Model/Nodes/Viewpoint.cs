/*! \file Viewpoint.cs
	\brief The Viewpoint node defines a viewpoint that provides a perspective view of the scene

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

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// The Viewpoint node defines a viewpoint that provides a perspective view of the scene. 
    /// A perspective view is one in which all projectors coalesce at position.
    /// </summary>
    public class Viewpoint : X3DViewpointNode
    {
        public Viewpoint() { }

        #region Properties
        [XmlIgnore]
        public SFVec3f? CenterOfRotation { get; set; }

        [XmlIgnore]
        public SFVec3f? Position { get; set; }
        #endregion Properties

        #region Serialization
        [XmlAttribute("centerOfRotation")]
        public string? CenterOfRotationText
        {
            get => CenterOfRotation?.ToString();
            set => CenterOfRotation = SFVec3f.CreateFromString(value);
        }

        [XmlAttribute("position")]
        public string? PositionAsText
        {
            get => Position?.ToString();
            set => Position = SFVec3f.CreateFromString(value);
        }

        /// <summary>
        /// The fieldOfView field specifies a preferred minimum viewing angle from this viewpoint in angle base units. 
        /// A small field of view roughly corresponds to a telephoto lens; 
        /// a large field of view roughly corresponds to a wide-angle lens. 
        /// The field of view shall be greater than zero and smaller than π. 
        /// The value of fieldOfView represents the minimum viewing angle in any direction axis perpendicular to the view.
        /// </summary>
        [XmlAttribute("fieldOfView")]
        [System.ComponentModel.DefaultValueAttribute(0.7854f)]
        public float FieldOfView { get; set; } = 0.7854f;
        #endregion Serialization
    }
}
