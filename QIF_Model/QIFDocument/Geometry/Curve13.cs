/*! \file Curve13.cs
	\brief The global Curve13 element is a 3D curve and is the head of a substitution group.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Geometry
{
	/// <remarks The Curve13BaseType is the abstract base type for all geometric
	/// 3D curves(curve(t):R1->R3) present in the CAD scene./>
	public abstract class Curve13BaseType : GeometryBaseType
	{
	}

	/// <remarks />
	public class Segment13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class ArcConic13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class ArcCircular13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class Nurbs13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class Spline13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class Aggregate13 : Curve13BaseType
	{
	}

	/// <remarks />
	public class Polyline13Core : Curve13BaseType
	{
	}

	/// <remarks />
	public class Polyline13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class Aggregate13Type : Curve13BaseType
	{
	}
}
