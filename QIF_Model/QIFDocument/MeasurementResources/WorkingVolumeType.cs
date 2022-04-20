/*! \file WorkingVolumeBaseType.cs
	\brief The base type for more precisely defined types of working volumes.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.MeasurementResources
{
	/// <remarks 
	/// The abstract WorkingVolumeBaseType is the base type for more
	/// precisely defined types of working volumes.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class WorkingVolumeBaseType
	{
	}

	/// <remarks 
	/// The ClosedShellSetWorkingVolumeType defines a working volume
	/// consisting of a set of closed outer shells.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class ClosedShellSetWorkingVolumeType : WorkingVolumeBaseType
	{
		/// <remarks 
		/// The ClosedShellSet element is the closed shells that
		/// define the working volume. />
		[XmlElement(IsNullable = false)]
		public ClosedShellSetType WorkingClosedShellSet { get; set; }
	}

	/// <remarks 
	/// The global WorkingClosedShellSet element gives information about a closed shell set.
	/// Each key in this element requires each item in a collection of
	/// items of the same type to have an id that is unique within the collection. 
	/// 
	/// The ClosedShellSetType defines a set of closed outer shells,
	/// including the geometry and topology of the components of the shells./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class ClosedShellSetType
	{
		/// <remarks 
		/// The optional PointSet element is a collection of all instances
		/// of PointEntityType present in the shell set. />
		[XmlElement(IsNullable = true)]
		public PointSetType PointSet { get; set; }

		/// <remarks 
		/// The optional Curve12Set element is a collection of all 2D
		/// curves(curve(t):R1->R2) present in the shell set.These curves
		/// are defined in the parametric space of a surface. />
		[XmlElement(IsNullable = true)]
		public Curve12SetType Curve12Set { get; set; }

		/// <remarks 
		/// The optional Curve13Set element is a collection of all 3D
		/// curves(curve(t):R1->R3) present in the shell set. />
		[XmlElement(IsNullable = true)]
		public Curve13SetType Curve13Set { get; set; }

		/// <remarks 
		/// The optional SurfaceSet element is a collection of all surfaces present in the shell set. />
		[XmlElement(IsNullable = true)]
		public SurfaceSetType SurfaceSet { get; set; }

		/// <remarks 
		/// The optional CurveMeshSet element is a collection of all mesh curves present in the shell set. />
		[XmlElement(IsNullable = true)]
		public CurveMeshSetType CurveMeshSet { get; set; }

		/// <remarks 
		/// The optional SurfaceMeshSet element is a collection of all mesh surfaces present in the shell set. />
		[XmlElement(IsNullable = true)]
		public SurfaceMeshSetType SurfaceMeshSet { get; set; }

		/// <remarks 
		/// The optional VertexSet element is a collection of all vertices used in the shell set. />
		[XmlElement(IsNullable = true)]
		public VertexSetType VertexSet { get; set; }

		/// <remarks 
		/// The optional EdgeSet element is a collection of all edges used in the shell set. />
		[XmlElement(IsNullable = true)]
		public EdgeSetType EdgeSet { get; set; }

		/// <remarks 
		/// The optional LoopSet element is a collection of all loops used in the shell set. />
		[XmlElement(IsNullable = true)]
		public LoopSetType LoopSet { get; set; }

		/// <remarks 
		/// The optional FaceSet element is a collection of all faces used in the shell set. />
		[XmlElement(IsNullable = true)]
		public FaceSetType FaceSet { get; set; }

		/// <remarks 
		/// The ShellSet element gives the set of boundary representation shells that define the working volume. />
		[XmlElement(IsNullable = true)]
		public ShellSetType ShellSet { get; set; }
	}

	/// <remarks 
	/// The CartesianWorkingVolumeType defines a box-shaped working volume
	/// whose sides are aligned with the axes of a 3D Cartesian	coordinate system.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class CartesianWorkingVolumeType : WorkingVolumeBaseType
	{
		/// <remarks 
		/// The optional XAxisLength element is the length of the Cartesian working volume in the X direction. />
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType XAxisLength { get; set; }

		/// <remarks 
		/// The optional YAxisLength element is the length of the Cartesian working volume in the Y direction. />
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType YAxisLength { get; set; }

		/// <remarks 
		/// The optional ZAxisLength element is the length of the Cartesian working volume in the Z direction. />
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType ZAxisLength { get; set; }
	}

	/// <remarks 
	/// The SphericalWorkingVolumeType defines a spherical working volume.
	/// A spherical working volume is defined based on a spherical
	/// coordinate system.Some measurement devices, such as laser tracker,
	/// operate based on a spherical coordinate system.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class SphericalWorkingVolumeType : WorkingVolumeBaseType
	{
		/// <remarks 
		/// The RadialAxisLength element is the radius of the spherical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType RadialAxisLength { get; set; }

		/// <remarks 
		/// The MinAzimuthalAxisAngle element is the start value of the range of azimuthal angle in a spherical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MinAzimuthalAxisAngle { get; set; }

		/// <remarks 
		/// The MaxAzimuthalAxisAngle element is the end value of the range of azimuthal angle in a spherical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MaxAzimuthalAxisAngle { get; set; }

		/// <remarks 
		/// The MinPolarAxisRange element is the start value of the range of the polar angle for a spherical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MinPolarAxisAngle { get; set; }

		/// <remarks 
		/// The MaxPolarAxisRange element is the end value of the range of the polar angle for a spherical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MaxPolarAxisAngle { get; set; }
	}

	/// <remarks 
	/// The CylindricalWorkingVolumeType defines a cylindrical working volume.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class CylindricalWorkingVolumeType : WorkingVolumeBaseType
	{
		/// <remarks 
		/// The RadialAxisLength element is the radial axis length of a cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType RadialAxisLength { get; set; }

		/// <remarks 
		/// The MinAzimuthalAxisAngle element is the start value of the range of azimuthal angle in a cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MinAzimuthalAxisAngle { get; set; }

		/// <remarks 
		/// The MaxAzimuthalAxisAngle element is the end value of the range of azimuthal angle in a cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MaxAzimuthalAxisAngle { get; set; }

		/// <remarks 
		/// The ZAxisLength element is the Z axis length of a cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType ZAxisLength { get; set; }
	}

	/// <remarks 
	/// The UserDefinedWorkingVolumeType defines a 3 dimensional working volume by three user defined axes.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class UserDefinedWorkingVolumeType : WorkingVolumeBaseType
	{
		/// <remarks 
		/// The FirstAxis element gives the axis length or angle and
		/// other details for the first axis of a user defined working volume. />
		[XmlElement(IsNullable = false)]
		public UserDefinedAxisType FirstAxis { get; set; }

		/// <remarks 
		/// The SecondAxis element gives the axis length or angle and
		/// other details for the second axis of a user defined working volume. />
		[XmlElement(IsNullable = false)]
		public UserDefinedAxisType SecondAxis { get; set; }

		/// <remarks 
		/// The ThirdAxis element gives the axis length or angle and
		/// other details for the third axis of a user defined working volume. />
		[XmlElement(IsNullable = false)]
		public UserDefinedAxisType ThirdAxis { get; set; }
	}
}
