/*! \file GeometrySetType.cs
    \brief Describes the main container for storing all geometric entities present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Geometry
{
	/// <remarks The GeometrySetType describes the main container for
	/// storing all geometric entities present in the CAD scene./>
	public class GeometrySetType
	{
		/// <remarks The optional PointSet element is a collection of all instances of PointEntityType present in the CAD scene./>
		[XmlElement()]
		public PointSetType PointSet { get; set; }

		/// <remarks The optional Curve12Set element is a collection of all 2D curves(curve(t):R1->R2) present in the CAD scene.
		/// These curves are defined in the parametric space of a surface./>
		[XmlElement()]
		public Curve12SetType Curve12Set { get; set; }

		/// <remarks The optional Curve13Set element is a collection of all 3D curves(curve(t):R1->R3) present in the CAD scene./>
		[XmlElement()]
		public Curve13SetType Curve13Set { get; set; }

		/// <remarks The optional SurfaceSet element is a collection of all surfaces present in the CAD scene./>
		[XmlElement()]
		public SurfaceSetType SurfaceSet { get; set; }

		/// <remarks The optional CurveMeshSet element is a collection of all mesh curves present in the CAD scene./>
		[XmlElement()]
		public CurveMeshSetType CurveMeshSet { get; set; }

		/// <remarks The optional SurfaceMeshSet element is a collection of all mesh surfaces present in the CAD scene./>
		[XmlElement()]
		public SurfaceMeshSetType SurfaceMeshSet { get; set; }
	}
}
