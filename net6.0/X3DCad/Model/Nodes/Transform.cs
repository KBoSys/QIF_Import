/*! \file Transform.cs
	\brief The Transform node is a grouping node that defines a coordinate system for its children that is relative to the coordinate systems of its ancestors.

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

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// The Transform node is a grouping node that defines a coordinate system for its children that is relative to the coordinate systems of its ancestors.
    /// </summary>
    public class Transform : X3DGroupingNode
    {
        #region Properties
        [XmlIgnore]
        public SFVec3f Center { get; set; } = new SFVec3f();

        [XmlIgnore]
        public SFRotation Rotation { get; set; } = new SFRotation();

        [XmlIgnore]
        public SFVec3f Scale { get; set; } = new SFVec3f(1, 1, 1);

        [XmlIgnore]
        public SFRotation ScaleOrientation { get; set; } = new SFRotation();

        [XmlIgnore]
        public SFVec3f Translation { get; set; } = new SFVec3f();
        #endregion Properties

        #region Serialization
        [XmlAttribute("center")]
        [System.ComponentModel.DefaultValueAttribute("0 0 0")]
        public string? CenterAsText { get => Center.ToString(); set => Center.FromString(value); }

        [XmlAttribute("rotation")]
        [System.ComponentModel.DefaultValueAttribute("0 0 1 0")]
        public string? RotationAsText { get => Rotation.ToString(); set => Rotation.FromString(value); }

        [XmlAttribute("scale")]
        [System.ComponentModel.DefaultValueAttribute("1 1 1")]
        public string? ScaleAsText { get => Scale.ToString(); set => Scale.FromString(value); }

        [XmlAttribute("scaleOrientation")]
        [System.ComponentModel.DefaultValueAttribute("0 0 1 0")]
        public string? ScaleOrientationAsText { get => ScaleOrientation.ToString(); set => ScaleOrientation.FromString(value); }

        [XmlAttribute("translation")]
        [System.ComponentModel.DefaultValueAttribute("0 0 0")]
        public string? TranslationAsText { get => Translation.ToString(); set => Translation.FromString(value); }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("children")]
        public string? Container { get; set; }
        #endregion Serialization
    }
}
