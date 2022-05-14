/*! \file CoordinateSystemSetType.cs
	\brief A container for storing all coordinate systems

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Auxiliary
{
	/// <remarks The CoordinateSystemSetType represents a container for storing all	coordinate systems present in the CAD scene./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class CoordinateSystemSetType
	{
		/// <remarks Each CoordinateSystem element is a coordinate system../>
		[XmlElement(ElementName = "CoordinateSystem", Type = typeof(CADCoordinateSystemType))]
		public CADCoordinateSystemType[] CoordinateSystems { get; set; }

		/// <remarks The required n attribute is the number of coordinate systems in this set./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.CoordinateSystems.Length;
		}
	}

	/// <remarks The CADCoordinateSystemType defines the Cartesian 3D coordinate system in the model space./>
	public class CADCoordinateSystemType : DrawableBaseType
	{
		/// <remarks The CoordinateSystemCore element defines the mathematical core of the coordinate system./>
		public Primitives.CoordinateSystemCoreType CoordinateSystemCore { get; set; }
	}
}
