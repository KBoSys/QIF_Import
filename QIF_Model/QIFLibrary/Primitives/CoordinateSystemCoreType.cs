/*! \file CoordinateSystemCoreType.cs
	\brief defines the mathematical core of a Cartesian right-handed 3D coordinate system

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
	/// <summary>
	/// The CoordinateSystemCoreType defines the mathematical core of a
	/// Cartesian right-handed 3D coordinate system.It is also the base of the TransformMatrixType
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class CoordinateSystemCoreType
	{
		public CoordinateSystemCoreType() { }

		/// <summary>
		/// The Rotation element is an orthogonal basis of the Cartesian coordinate system.
		/// </summary>
		[XmlElement]
		public TransformRotationType Rotation { get; set; }

		/// <summary>
		/// The Origin element is an origin of the coordinate system.
		/// </summary>
		[XmlElement]
		public PointSimpleType Origin { get; set; }
	}

	/// <summary>
	/// The TransformRotationType defines a transformation for a rotation.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class TransformRotationType
	{
		public TransformRotationType() { }

		/// <summary>
		/// The XDirection element is a unit vector that specifies the x
		/// rotation.When the origin is (0,0,0), the components of the X
		/// direction are the coordinates in the 'after' coordinate system
		/// of the point(1,0,0) in the 'before' system.
		/// </summary>
		[XmlElement]
		public UnitVectorSimpleType XDirection { get; set; }

		/// <summary>
		/// The YDirection element is a unit vector that describes the y
		/// rotation.When the origin is (0,0,0), the components of the Y
		/// direction are the coordinates in the 'after' coordinate system
		/// of the point(0,1,0) in the 'before' system.
		/// </summary>
		[XmlElement]
		public UnitVectorSimpleType YDirection { get; set; }

		/// <summary>
		/// The ZDirection element is a unit vector that describes the z
		/// rotation.When the Origin is (0,0,0), the components of the z
		/// Direction are the coordinates in the 'after' coordinate system
		/// of the point(0,0,1) in the 'before' system.
		/// </summary>
		[XmlElement]
		public UnitVectorSimpleType ZDirection { get; set; }
	}
}
