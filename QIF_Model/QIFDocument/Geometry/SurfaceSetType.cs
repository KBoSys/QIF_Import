/*! \file SurfaceSetType.cs
	\brief The SurfaceSetType represents a container for storing all surfaces present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Geometry
{
	public class SurfaceSetType
	{
		/// <remarks Each Surface element is a surface (surface(u, v):R2->R3)./>
		[XmlElement("Nurbs23", Type = typeof(Nurbs23Type))]
		[XmlElement("Spline23", Type = typeof(Spline23Type))]
		[XmlElement("Revolution23", Type = typeof(Revolution23Type))]
		[XmlElement("Extrude23", Type = typeof(Extrude23Type))]
		[XmlElement("Ruled23", Type = typeof(Ruled23Type))]
		[XmlElement("Offset23", Type = typeof(Offset23Type))]
		[XmlElement("Plane23", Type = typeof(Plane23Type))]
		[XmlElement("Cone23", Type = typeof(Cone23Type))]
		[XmlElement("Cylinder23", Type = typeof(Cylinder23Type))]
		[XmlElement("Sphere23", Type = typeof(Sphere23Type))]
		[XmlElement("Torus23", Type = typeof(Torus23Type))]
		public SurfaceBaseType[] Surfaces { get; set; }

		/// <remarks The required n attribute is the number of surfaces in this set./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Surfaces.Length;
		}
	}
}
