/*! \file Normal.cs
	\brief Defines a set of 3D direction vectors to be used for the normal field of some geometry nodes

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
    /// 
    /// </summary>
    public enum ContainerFieldChoicesX3DNormalNode
    {
        /// <summary>
        /// parent node is a geometry node
        /// </summary>
        normal,

        /// <summary>
        /// parent node is HAnimHumanoid
        /// </summary>
        skinNormal,

        /// <summary>
        /// parent node is HAnimHumanoid, added in X3D version 4
        /// </summary>
        skinBindingNormals,
    }

    /// <summary>
    /// This node defines a set of 3D direction vectors to be used for the normal field of some geometry nodes
    /// </summary>
    public class Normal : X3DNormalNode
    {
        [XmlIgnore]
        public MFVec3f? Vector { get; set; }

        [XmlAttribute("vector")]
        public string? VectorAsText 
        { 
            get => Vector?.ToString(); 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Vector = null;
                }
                else
                {
                    Vector = new MFVec3f();
                    Vector?.FromString(value);
                }
            }
        }

        [XmlElement("containerField")]
        [System.ComponentModel.DefaultValueAttribute(ContainerFieldChoicesX3DNormalNode.normal)]
        public ContainerFieldChoicesX3DNormalNode NormalNode { get; set; } = ContainerFieldChoicesX3DNormalNode.normal;
    }
}
