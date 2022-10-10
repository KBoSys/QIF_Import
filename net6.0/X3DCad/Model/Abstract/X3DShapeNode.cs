/*! \file X3DShapeNode.cs
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

        /// <summary>
        /// GeometryContentModel is the child-node content model corresponding to X3DGeometryNode.   No more than one instance of any single geometry node is allowed.
        /// </summary>
        #region <xs:group name="GeometryContentModel">

        #region <xs:group ref="GeometryContentModelInterchange"/>
        [XmlElement("Box", typeof(Box))]
        [XmlElement("Cone", typeof(Cone))]
        [XmlElement("Cylinder", typeof(Cylinder))]
        [XmlElement("Sphere", typeof(Sphere))]
        [XmlElement("PointSet", typeof(PointSet))]
        [XmlElement("LineSet", typeof(LineSet))]
        [XmlElement("IndexedFaceSet", typeof(IndexedFaceSet))]
        [XmlElement("IndexedTriangleSet", typeof(IndexedTriangleSet))]
        [XmlElement("IndexedTriangleFanSet", typeof(IndexedTriangleFanSet))]
        [XmlElement("IndexedLineSet", typeof(IndexedLineSet))]
        [XmlElement("IndexedTriangleStripSet", typeof(IndexedTriangleStripSet))]
        [XmlElement("TriangleFanSet", typeof(TriangleFanSet))]
        [XmlElement("TriangleSet", typeof(TriangleSet))]
        [XmlElement("TriangleSet2D", typeof(TriangleSet2D))]
        [XmlElement("TriangleStripSet", typeof(TriangleStripSet))]
        #endregion

        #region <xs:group ref="GeometryContentModelInteractive"/>
        #endregion

        /// <summary>
        /// 
        /// </summary>
        #region <xs:group ref="GeometryContentModelImmersive"/>
        //<xs:group ref="GeometryContentModel2DImmersive"/>
        //<xs:element ref="Extrusion"/>
        [XmlElement("Text", typeof(CADText))]
        #endregion

        /// <summary>
        /// Child-node content model corresponding to Geometry2D component.
        /// </summary>
        #region <xs:group ref="GeometryContentModel2D"/>
        [XmlElement("Arc2D", typeof(Arc2D))]
        [XmlElement("ArcClose2D", typeof(ArcClose2D))]
        [XmlElement("Disk2D", typeof(Disk2D))]
        [XmlElement("Circle2D", typeof(Circle2D))]
        #endregion

        /// <summary>
        /// Child-node content model corresponding to nodes in CAD component.
        /// </summary>
        #region <xs:group ref="GeometryContentModelCAD"/>
        [XmlElement("QuadSet", typeof(QuadSet))]
        [XmlElement("IndexedQuadSet", typeof(IndexedQuadSet))]
        #endregion

        #region <xs:group ref="GeometryContentModelGeoSpatial"/>
        #endregion

        #region <xs:group ref="GeometryContentModelNurbs"/>
        #endregion

        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object? Geometry { get; set; }
        #endregion <xs:group name="GeometryContentModel">

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

        #endregion Serialization
    }
}
