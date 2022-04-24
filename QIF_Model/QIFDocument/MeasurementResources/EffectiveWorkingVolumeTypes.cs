/*! \file WorkingVolumeBaseType.cs
	\brief More precisely defined types that represent the size and location of an available working volume without any obstacle

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.MeasurementResources
{
	/// <remarks 
	/// The abstract EffectiveWorkingVolumeBaseType is the base type for
	/// more precisely defined types that represent the size and location
	/// of an available working volume without any obstacle.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class EffectiveWorkingVolumeBaseType
	{
	}

	/// <remarks 
	/// The EffectiveCylindricalWorkingVolumeType defines the size
	/// and location of a cylindrical working volume that is aligned
	/// with the axes of a cylindrical coordinate system.This working
	/// volume is defined by giving the start and end values of the
	/// radius, azimuth and height of(partial) cylinder.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class EffectiveCylindricalWorkingVolumeType : EffectiveWorkingVolumeBaseType
	{
		/// <remarks The MinRadius element is the minimum radius of an effective cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType MinRadius { get; set; }

		/// <remarks The MaxRadius element is the maximum radius of an effective cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType MaxRadius { get; set; }

		/// <remarks The MinAzimuthalAxisAngle element is the minimum azimuthal angle of an effective cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MinAzimuthalAxisAngle { get; set; }

		/// <remarks The MaxAzimuthalAxisAngle element is the maximum azimuthal angle of an effective cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MaxAzimuthalAxisAngle { get; set; }

		/// <remarks The MinZAxis element is the minimum length (height) of cylinder for an effective cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType MinZAxis { get; set; }

		/// <remarks The MaxZAxis element is the maximum length (height) for an effective cylindrical working volume. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType MaxZAxis { get; set; }
	}

	/// <remarks 
	/// The EffectiveSphericalWorkingVolumeType defines the size and
	/// location of a spherical working volume that is aligned with the
	/// axes of a spherical coordinate system.The(Partial) sphere is
	/// described by giving the starting and ending values of radius, angle, and height.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class EffectiveSphericalWorkingVolumeType : EffectiveWorkingVolumeBaseType
	{
		/// <remarks The MinRadialAxis element is the minimum value of the radius. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType MinRadialAxis { get; set; }

		/// <remarks The MaxRadialAxis element is the maximum value of the radius. />
		[XmlElement(IsNullable = false)]
		public Units.LinearValueType MaxRadialAxis { get; set; }

		/// <remarks The MinAzimuthalAxisAngle element is the minimum value of the azimuthal angle. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MinAzimuthalAxisAngle { get; set; }

		/// <remarks The MaxAzimuthalAxisAngle element is the maximum value of the azimuthal angle. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MaxAzimuthalAxisAngle { get; set; }

		/// <remarks The MinPolarAxis element is the minimum value of the polar angle. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MinPolarAxis { get; set; }

		/// <remarks The MaxPolarAxis element is the maximum value of the polar angle. />
		[XmlElement(IsNullable = false)]
		public Units.AngularValueType MaxPolarAxis { get; set; }
	}

	/// <remarks 
	/// The EffectiveCartesianWorkingVolumeType defines the size and
	/// location of a box-shaped working volume whose sides are aligned
	/// with the axes of a 3D Cartesian coordinate system.The box is
	/// described by giving the points at diagonally opposite corners of
	/// the box, one with minimum XYZ values, the other with maximum XYZ values.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class EffectiveCartesianWorkingVolumeType : EffectiveWorkingVolumeBaseType
	{
		/// <remarks The MinPoint element is the minimum corner of the working volume. />
		[XmlElement(IsNullable = false)]
		public Primitives.PointType MinPoint { get; set; }

		/// <remarks The MaxPoint element is the maximum corner of the working volume. />
		[XmlElement(IsNullable = false)]
		public Primitives.PointType MaxPoint { get; set; }
	}

	/// <remarks 
	/// The EffectiveClosedShellSetWorkingVolumeType defines an effective
	/// working volume consisting of a set of closed outer shells.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class EffectiveClosedShellSetWorkingVolumeType : EffectiveWorkingVolumeBaseType
	{
		/// <remarks The ClosedShellSet element is the closed shells that define the effective working volume. />
		[XmlElement(IsNullable = false)]
		public ClosedShellSetType WorkingClosedShellSet { get; set; }
	}

	/// <remarks 
	/// The EffectiveUserDefinedWorkingVolumeType defines an effective user
	/// defined working volume type.It identifies the corresponding user
	/// defined working volume and gives values for the minimum and maximum
	/// on each axis.The axes and the units for axis values are those used
	/// in the corresponding user defined working volume
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class EffectiveUserDefinedWorkingVolumeType : EffectiveWorkingVolumeBaseType
	{
		/// <remarks The UserDefinedWorkingVolumeId element is the id of the corresponding user defined working volume./>
		[XmlElement(IsNullable = false)]
		public Primitives.QIFReferenceType UserDefinedWorkingVolumeId { get; set; }

		/// <remarks The MinFirstAxis element is the starting value of the first axis./>
		[XmlElement(IsNullable = false)]
		public Units.MeasuredDecimalType MinFirstAxis { get; set; }

		/// <remarks The MaxFirstAxis element is the ending value of the first axis./>
		[XmlElement(IsNullable = false)]
		public Units.MeasuredDecimalType MaxFirstAxis { get; set; }

		/// <remarks The MinSecondAxis element is the starting value of the second axis./>
		[XmlElement(IsNullable = false)]
		public Units.MeasuredDecimalType MinSecondAxis { get; set; }

		/// <remarks The MaxSecondAxis element is the ending value of the second axis./>
		[XmlElement(IsNullable = false)]
		public Units.MeasuredDecimalType MaxSecondAxis { get; set; }

		/// <remarks The MinThirdAxis element is the starting value of the third axis./>
		[XmlElement(IsNullable = false)]
		public Units.MeasuredDecimalType MinThirdAxis { get; set; }

		/// <remarks The MaxThirdAxis element is the ending value of the third axis./>
		[XmlElement(IsNullable = false)]
		public Units.MeasuredDecimalType MaxThirdAxis { get; set; }
	}
}
