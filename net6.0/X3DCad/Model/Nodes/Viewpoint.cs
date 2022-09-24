/*! \file Viewpoint.cs
	\brief 

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
    /// 
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
        //<xs:attribute name = "centerOfRotation" type="SFVec3f" default="0 0 0"/>
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

        [XmlAttribute("fieldOfView")]
        [System.ComponentModel.DefaultValueAttribute(0.7854f)]
        public float FieldOfView { get; set; } = 0.7854f;
        #endregion Serialization
    }
}
