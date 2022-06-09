/*! \file CurveCoreBaseType.cs
	\brief abstract base type for all mathematical cores of 2D and 3D curves present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Geometry
{
	/// <remarks The CurveCoreBaseType is the abstract base type for all mathematical
	/// cores of 2D and 3D curves present in the CAD scene./>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline12CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline13CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate13CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate12CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline12CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline13CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs13CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs12CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular12CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular13CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic12CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic13CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment12CoreType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment13CoreType))]
	public abstract class CurveCoreBaseType
	{
		private QIFLibrary.Primitives.ParameterRangeType rangeField;

		/// <remarks The required domain attribute is the domain of the parameterization of the curve./>
		[System.Xml.Serialization.XmlAttribute("domain")]
		public double[] Domain { get => rangeField; set => rangeField = value; }
	}

}
