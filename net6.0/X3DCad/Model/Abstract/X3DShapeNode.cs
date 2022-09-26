﻿/*! \file X3DShapeNode.cs
	\brief Base type for all Shape nodes.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Geometry;
using X3DCad.Model.Nodes;
using X3DCad.Model.Types;
using static System.Net.Mime.MediaTypeNames;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Base type for all Shape nodes.
    /// </summary>
    public class X3DShapeNode : X3DChildNode
    {
        #region Properties
        [XmlIgnore]
        public SFVec3f? BboxCenter { get; set; }

        [XmlIgnore]
        public bboxSizeType? BboxSizeType { get; set; }
        #endregion

        #region Serialization

        #region <xs:group name="GeometryContentModel">
        //<xs:group ref="GeometryContentModelInterchange"/>
        //<xs:group ref="GeometryContentModelInteractive"/>
        //<xs:group ref="GeometryContentModelImmersive"/>
        //<xs:group ref="GeometryContentModel2D"/>
        //<xs:group ref="GeometryContentModelCAD"/>
        //<xs:group ref="GeometryContentModelGeoSpatial"/>
        //<xs:group ref="GeometryContentModelNurbs"/>
        [XmlElement("Box", typeof(Box))]
        [XmlElement("Cylinder", typeof(Cylinder))]
        [XmlElement("Cone", typeof(Cone))]
        [XmlElement("Sphere", typeof(Sphere))]
        [XmlElement("Text", typeof(CADText))]
        [XmlElement("IndexedFaceSet", typeof(IndexedFaceSet))]
        [XmlElement("IndexedTriangleSet", typeof(IndexedTriangleSet))]
        [XmlElement("IndexedTriangleFanSet", typeof(IndexedTriangleFanSet))]
        #endregion
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object? Geometry { get; set; }
        #endregion

        /// <summary>
        /// ShapeChildContentModel is the child-node content model utilized by X3DShapeNode.  
        /// ShapeChildContentModel can contain a single Appearance node and a single geometry node, in any order.
        /// </summary>
        #region <xs:group ref="ShapeChildContentModel" minOccurs="0"/>
        [XmlElement]
        public Appearance? Appearance { get; set; }

        [XmlAttribute("bboxCenter")]
        public string? BboxCenterText { get => BboxCenter?.ToString(); set => BboxCenter = SFVec3f.CreateFromString(value); }

        [XmlAttribute("bboxSize")]
        public string? BboxSizeText { get => BboxSizeType?.ToString(); set => BboxSizeType = bboxSizeType.CreateFromString(value); }

        [XmlAttribute("bboxDisplay")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool BboxDisplay { get; set; } = false;

        [XmlAttribute("castShadow")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool CastShadow { get; set; } = true;

        [XmlAttribute("visible")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Visible { get; set; } = true;

        #endregion
    }
}
