/*! \file CurveSets.cs
	\brief Containers for storing all 2D and 3D curves present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications.MeasurementResources;
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks> The Curve12SetType represents a container for storing all 2D curves present in the CAD scene.</remarks>
    public class Curve12SetType : ArrayBaseType<Curve12BaseType>
    {
        /// <remarks> Each Curve12 element is a 2D curves (curve(t):R1->R2) defined in the parametric space of a surface. </remarks>
        [XmlElement("Segment12", Type = typeof(Segment12Type))]
        [XmlElement("ArcConic12", Type = typeof(ArcConic12Type))]
        [XmlElement("ArcCircular12", Type = typeof(ArcCircular12Type))]
        [XmlElement("Nurbs12", Type = typeof(Nurbs12Type))]
        [XmlElement("Spline12", Type = typeof(Spline12Type))]
        [XmlElement("Aggregate12", Type = typeof(Aggregate12Type))]
        [XmlElement("Polyline12", Type = typeof(Polyline12Type))]
        public Curve12BaseType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The Curve13SetType represents a container for storing all 3D curves present in the CAD scene.</remarks>
    public class Curve13SetType : ArrayBaseType<Curve13BaseType>
    {
        /// <remarks> Each Curve13 element is a 3D curve (curve(t):R1->R3). </remarks>
        [XmlElement("Segment13", Type = typeof(Segment13Type))]
        [XmlElement("ArcConic13", Type = typeof(ArcConic13Type))]
        [XmlElement("ArcCircular13", Type = typeof(ArcCircular13Type))]
        [XmlElement("Nurbs13", Type = typeof(Nurbs13Type))]
        [XmlElement("Spline13", Type = typeof(Spline13Type))]
        [XmlElement("Aggregate13", Type = typeof(Aggregate13Type))]
        [XmlElement("Polyline13", Type = typeof(Polyline13Type))]
        public Curve13BaseType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
