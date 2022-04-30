/*! \file Curve12.cs
	\brief The Curve12BaseType is the abstract base type for all geometric
        2D curves (curve(t):R1->R2) present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Geometry
{
	/// <remarks The Curve12BaseType is the abstract base type for all geometric 2D curves(curve(t):R1->R2) present in the CAD scene./>
	public abstract class Curve12BaseType : GeometryBaseType
	{
	}

	/// <remarks The Segment12Type defines the geometric entity
	/// 'linear_segment(t):R1->R2'. The 2D curves
	/// are normally used to define a trimming curve in the
	/// parametric space of a surface./>
	public class Segment12Type : Curve12BaseType
	{
		/// <remarks The Segment12Core element defines the mathematical core of this curve type./>
		[XmlElement(IsNullable = false)]
		public Segment12CoreType Segment12Core { get; set; }
	}

	/// <remarks The CurveCoreBaseType is the abstract base type for all mathematical
	/// cores of 2D and 3D curves present in the CAD scene./>
	public abstract class CurveCoreBaseType
	{
		/// <remarks The required domain attribute is the domain of the parameterization of the curve./>
		//[XmlAttribute("domain")]
		[XmlElement("domain", IsNullable = true)]
		public QIFLibrary.Primitives.ParameterRangeType Domain { get; set; }
	}

	/// <remarks The Segment12CoreType defines the mathematical core of the
	/// geometric entity 'linear_segment(t):R1->R2'. It represents a
	/// portion of a 2D line defined and bounded by a start point and an end point./>
	public class Segment12CoreType : CurveCoreBaseType
	{
	}

	/// <remarks The ArcConicFormEnumType enumerates values that describe the conic arc form and can take the following values:
	/// 'PARABOLA' - a parabola;
	/// 'ELLIPSE' - an ellipse;
	/// 'HYPERBOLA' - a hyperbola;/>
	public enum ArcConicFormEnumType
	{
		PARABOLA, ELLIPSE, HYPERBOLA
	}

	/// <remarks />
	public class ArcConic12Type : Curve12BaseType
	{

	}

	/// <remarks />
	public class ArcCircular12Type : Curve12BaseType
	{

	}

	/// <remarks />
	public class Nurbs12Type : Curve12BaseType
	{

	}

	/// <remarks />
	public class Spline12Type : Curve12BaseType
	{

	}

	/// <remarks />
	public class Aggregate12Type : Curve12BaseType
	{

	}

	/// <remarks />
	public class Polyline12Type : Curve12BaseType
	{

	}
}
