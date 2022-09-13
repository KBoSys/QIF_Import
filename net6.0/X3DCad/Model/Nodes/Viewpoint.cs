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
    public class Viewpoint : X3DViewpointNode
    {
        private SFVec3f centerOfRotationField = new SFVec3f();
        public Viewpoint() { }

        //<xs:attribute name = "centerOfRotation" type="SFVec3f" default="0 0 0"/>
        [XmlAttribute("centerOfRotation")]
        public string? CenterOfRotationText
        {
            get => centerOfRotationField.ToString();
            set => centerOfRotationField.FromString(value);
        }

        [XmlAttribute("fieldOfView")]
        [System.ComponentModel.DefaultValueAttribute(0.7854f)]
        public float FieldOfView { get; set; } = 0.7854f;
    }
}
