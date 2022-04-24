/*! \file PointSet.cs
	\brief The PointSetType represents a container for storing all
        instances of PointEntityType present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Geometry
{
	/// <remarks The PointSetType represents a container for storing all instances of PointEntityType present in the CAD scene./>
	public class PointSetType
	{
		/// <remarks Each Point element is an instance of PointEntityType. Point
		/// elements are normally used as the underlying geometry for vertices. />
		[XmlElement("Point", Type = typeof(PointEntityType))]
		public PointEntityType[] Points { get; set; }

		/// <remarks The required n attribute is the number of points in this set./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Points.Length;
		}
	}

	/// <remarks The PointEntityType is a geometric entity that is a 3D point. 
	/// It is normally used as underlying geometry for vertices./>
	public class PointEntityType : GeometryBaseType
	{
		/// The XYZ element is the Cartesian three-dimensional coordinates of the 3D point./>
		[XmlElement(IsNullable = false)]
		public Primitives.PointSimpleType XYZ { get; set; }
	}
}
