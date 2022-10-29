/*! \file NavigationInfo.cs
	\brief The NavigationInfo node contains information describing the physical characteristics of the viewer's avatar and viewing model.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Helpers;
using X3DCad.Model.Abstract;
using X3DCad.Model.Types;

/// <summary>
/// navigationTransitionTypeValues are supported enumeration values for the transitionType field in the NavigationInfo node. 
/// This list is unbounded, additional enumeration values are allowed.
/// </summary>
[Flags]
[DefaultValue(NavigationTransitionTypeValues.NONE)]
public enum NavigationTransitionTypeValues
{
    NONE = 0,

    /// <summary>
    /// immediate transition
    /// </summary>
    TELEPORT = (1 << 0),

    /// <summary>
    /// transition may proceed directly through intervening objects
    /// </summary>
    LINEAR = (1 << 1),

    /// <summary>
    /// rowser-specific transition
    /// </summary>
    ANIMATE = (1 << 2),
}

/// <summary>
/// navigationTypeValues are supported enumeration values for the type field in the NavigationInfo node. 
/// This list is unbounded, additional enumeration values are allowed.
/// </summary>
[Flags]
[DefaultValue(NavigationTypeValues.NONE)]
public enum NavigationTypeValues
{
    /// <summary>
    /// disables all navigation interfaces
    /// </summary>
    NONE = 0x0000,

    /// <summary>
    /// browser can offer any type for user to choose
    /// </summary>
    ANY = (1 << 0),

    /// <summary>
    /// free navigation, avatar remains on ground, collision detection
    /// </summary>
    WALK = (1 << 1),

    /// <summary>
    /// view an individual object by rotating view about center
    /// </summary>
    EXAMINE = (1 << 2),

    /// <summary>
    /// free navigation, collision detection
    /// </summary>
    FLY = (1 << 3),

    /// <summary>
    /// navigate to particular object
    /// </summary>
    LOOKAT = (1 << 4),

    /// <summary>
    /// consistent keystroke navigation for both geospatial and Cartesian modes
    /// </summary>
    EXPLORE = (1 << 5),
}

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// The NavigationInfo node contains information describing the physical characteristics of the viewer's avatar and viewing model.
    /// </summary>
    public class NavigationInfo : X3DBindableNode
    {
        #region Fields
        private MFFloat avatarSizeField;
        #endregion Fields

        public NavigationInfo()
        {
            avatarSizeField = new MFFloat() {0.25f, 1.6f, 0.75f};
        }

        #region Properties
        [XmlIgnore]
        public NavigationTypeValues Type { get; set; } = NavigationTypeValues.EXAMINE | NavigationTypeValues.ANY;

        [XmlIgnore]
        public NavigationTransitionTypeValues TransitionType { get; set; } = NavigationTransitionTypeValues.LINEAR;
        #endregion Properties

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

        [XmlAttribute("transitionType", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("LINEAR")]
        public string[]? TransitionTypeAsString 
        {
            get => Converter.FlagsEnumToStringArray(TransitionType).ToArray();
            set => TransitionType = Converter.StringToFlagsEnum<NavigationTransitionTypeValues>(value);
        }

        /// <summary>
        /// The type field specifies an ordered list of navigation paradigms that specify a combination of navigation types and the initial navigation type.
        /// type attribute support for at least "ANY", "FLY", "EXAMINE", and "NONE" at level 1,
        /// plus support for "WALK", "LOOKAT" at level 2.
        /// </summary>
        [XmlAttribute("type", DataType = "token")]
        public string[]? TypeAsString 
        { 
            get => Converter.FlagsEnumToStringArray(Type).ToArray(); 
            set => Type = Converter.StringToFlagsEnum<NavigationTypeValues>(value);
        }

        [XmlAttribute("visibilityLimit")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public float VisibilityLimit { get; set; } = 0.0f;

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
    }
}
