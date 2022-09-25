/*! \file Shape.cs
	\brief The Shape node has two fields, appearance and geometry, that are used to create rendered objects in the world. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// containerFieldChoicesGroupLODShapeTransform lists the allowed containerField enumeration values for Shape, Transform and LOD nodes: "children" if parent node has abstract type X3DGroupingNode, otherwise "metadata" default.
    /// </summary>
    public enum ContainerFieldChoicesGroupLODShapeTransform
    {
        /// <summary>
        /// parent node has abstract type X3DGroupingNode
        /// </summary>
        children,

        /// <summary>
        /// parent node is Collision
        /// </summary>
        proxy,

        /// <summary>
        /// parent node is GeoLOD
        /// </summary>
        rootNode,

        /// <summary>
        /// parent node is CADFace or CollidableShape
        /// </summary>
        shape,

        /// <summary>
        /// parent node is HAnimHumanoid
        /// </summary>
        skin,
    }

    /// <summary>
    /// The Shape node has two fields, appearance and geometry, that are used to create rendered objects in the world. 
    /// The appearance field contains an Appearance node that specifies the visual attributes ( e.g., material and texture) to be applied to the geometry. 
    /// The geometry field contains a geometry node. The specified geometry node is rendered with the specified appearance nodes applied. 
    /// </summary>
    public class Shape : X3DShapeNode
    {
        [XmlAttribute("containerField")]
        [System.ComponentModel.DefaultValueAttribute(ContainerFieldChoicesGroupLODShapeTransform.children)]
        public ContainerFieldChoicesGroupLODShapeTransform ContainerField { get; set; } = ContainerFieldChoicesGroupLODShapeTransform.children;
    }
}
