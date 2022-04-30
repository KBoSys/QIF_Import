/*! \file Surfaces.cs
	\brief The SurfaceBaseType is the abstract base type for all geometric
        surfaces (R2->R3) present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Geometry
{
	/// <remarks The SurfaceBaseType is the abstract base type for all geometric surfaces(R2->R3) present in the CAD scene./>
	public abstract class SurfaceBaseType : GeometryBaseType
	{
	}

	/// <remarks />
	public class Nurbs23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Spline23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Revolution23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Extrude23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Ruled23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Offset23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Plane23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Cone23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Cylinder23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Sphere23Type : SurfaceBaseType
	{
	}

	/// <remarks />
	public class Torus23Type : SurfaceBaseType
	{
	}
}
