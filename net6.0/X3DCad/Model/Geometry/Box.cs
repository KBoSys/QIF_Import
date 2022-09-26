/*! \file Box.cs
	\brief Specifies a rectangular parallelepiped box

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
    /// The Box node specifies a rectangular parallelepiped box centred at (0, 0, 0) in the local coordinate system and aligned with the local coordinate axes.
    /// </summary>
    public class Box : Geometry3DBase
    {
        #region Properties
        [XmlIgnore]
        public SFVec3f Size { get; set; } = new SFVec3f(2, 2, 2);
        #endregion Properties

        #region Serialization
        [XmlAttribute("size")]
        [System.ComponentModel.DefaultValueAttribute("2 2 2")]
        public string? SizeAsText { get => Size.ToString(); set => Size.FromString(value); }
        #endregion Serialization
    }
}
