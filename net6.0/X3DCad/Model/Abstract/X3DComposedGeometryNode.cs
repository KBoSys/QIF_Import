﻿/*! \file X3DComposedGeometryNode.cs
	\brief Composed geometry nodes produce renderable geometry, can contain Color Coordinate Normal TextureCoordinate, and are contained by a Shape node.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using X3DCad.Model.Geometry;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Composed geometry nodes produce renderable geometry, can contain Color Coordinate Normal TextureCoordinate, and are contained by a Shape node.
    /// </summary>
    public abstract class X3DComposedGeometryNode : X3DGeometryNode
    {
        [XmlAttribute("ccw")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool CCW { get; set; } = true;

        [XmlAttribute("colorPerVertex")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool ColorPerVertex { get; set; } = true;

        [XmlAttribute("normalPerVertex")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool NormalPerVertex { get; set; } = true;

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Solid { get; set; } = true;

        /// <summary>
        /// ComposedGeometryContentModel is the child-node content model utilized by X3DComposedGeometryNodes.  
        /// It can contain Color(or ColorRGBA), Coordinate, Normal and TextureCoordinate, in any order.
        /// No more than one instance of these nodes is allowed.
        /// Multiple VertexAttribute (FloatVertexAttribute, Matrix3VertexAttribute, Matrix4VertexAttribute) nodes can also be contained.
        /// </summary>
        #region <xs:group ref="ComposedGeometryContentModel" minOccurs="0" maxOccurs="unbounded"/>
        // FloatVertexAttribute
        // Matrix3VertexAttribute
        // Matrix4VertexAttribute
        // Color
        // ColorRGBA
        // CoordinateDouble
        // GeoCoordinate
        // FogCoordinate
        // Normal
        // TextureCoordinate
        // TextureCoordinate3D
        // TextureCoordinate4D
        // TextureCoordinateGenerator
        // MultiTextureCoordinate
        // NurbsTextureCoordinate

        [XmlElement("Coordinate", typeof(Coordinate))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object? Item { get; set; }
        #endregion
    }
}
