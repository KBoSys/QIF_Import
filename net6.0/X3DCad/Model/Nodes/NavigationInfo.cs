/*! \file NavigationInfo.cs
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
    public class NavigationInfo : X3DBindableNode
    {
        private MFFloat avatarSizeField = new MFFloat();

        [XmlAttribute("avatarSize")]
        [System.ComponentModel.DefaultValueAttribute("0.25 1.6 0.75")]
        public string? AvatarSize { get => avatarSizeField.ToString(); set => avatarSizeField.FromString(value); }

        [XmlAttribute("headlight")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Headlight { get; set; } = true;

        [XmlAttribute("speed")]
        [System.ComponentModel.DefaultValueAttribute(1.0f)]
        public float Speed { get; set; } = 1.0f;

        /// <summary>
        /// SFTime specifies a single time value, expressed as a double-precision floating point number. 
        /// Typically, SFTime fields represent the number of seconds since Jan 1, 1970, 00:00:00 GMT.
        /// </summary>
        [XmlAttribute("transitionTime")]
        [System.ComponentModel.DefaultValueAttribute(1.0f)]
        public double TransitionTime { get; set; } = 1.0f;

        [XmlAttribute("transitionType")]
        [System.ComponentModel.DefaultValueAttribute("LINEAR")]
        public string? TransitionType { get; set; }

        /// <summary>
        /// type attribute support for at least "ANY", "FLY", "EXAMINE", and "NONE" at level 1,
        /// plus support for "WALK", "LOOKAT" at level 2.
        /// </summary>
        [XmlAttribute("type")]
        public string[]? Type { get; set; } = new string[] { "EXAMINE", "ANY" };

        [XmlAttribute("visibilityLimit")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public float VisibilityLimit { get; set; } = 0.0f;

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
    }
}
