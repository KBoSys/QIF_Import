/*! \file GeometryBaseType.cs
	\brief The GeometryBaseType is the abstract base type for all geometric elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks The GeometryBaseType is the abstract base type for all geometric elements./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeshTriangleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PathTriangulationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Torus23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Sphere23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cylinder23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cone23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plane23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Offset23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ruled23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Extrude23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Revolution23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Curve13BaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Curve12BaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointEntityType))]
    public abstract class GeometryBaseType : QIFLibrary.PrimitivesPD.NodeWithIdBaseType
	{
	}
}
