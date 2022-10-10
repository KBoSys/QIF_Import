/*! \file X3DGeometryNode.cs
	\brief This is the base node type for all geometry in X3D.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Geometry;
using static System.Net.Mime.MediaTypeNames;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// This is the base node type for all geometry in X3D.
    /// Geometry nodes produce renderable geometry and are contained by a Shape node.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(X3DComposedGeometryNode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(X3DParametricGeometryNode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Arc2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcClose2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Box))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Circle2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cone))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cylinder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Disk2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElevationGrid))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Extrusion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IndexedLineSet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineSet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointSet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polypoint2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Rectangle2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Sphere))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Text))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangleSet2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoElevationGrid))]
    public abstract class X3DGeometryNode : X3DNode
    {
    }
}
