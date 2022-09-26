/*! \file Sphere.cs
	\brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// 
    /// </summary>
    public class Sphere : Geometry3DBase
    {
        [XmlAttribute("radius")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float Radius { get; set; } = 1;
    }
}
