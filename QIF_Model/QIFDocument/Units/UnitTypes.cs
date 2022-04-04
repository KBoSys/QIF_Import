/*! \file Units.cs
    \brief Physical units

	The Units.cs file defines types that describe physical units,
    such as length, angle, and temperature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Units
{
	/// <summary>
	/// The AngularUnitType defines the units to be used in the
	/// expression of angular values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class AngularUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of angle. 
		/// If the element is used, its value must be radian.
		/// </summary>
		public AngularUnitType() : base("radian")
		{
		}
	}

	/// <summary>
	/// The AreaUnitType defines the units to be used in the expression of area values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class AreaUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of
		/// area.If the element is used, its value must be square meter.
		/// </summary>
		public AreaUnitType() : base("square meter")
		{
		}
	}

	/// <summary>
	/// The ForceUnitType defines the units to be used in the expression of	force values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class ForceUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of
		/// force.If the element is used, its value must be newton.
		/// </summary>
		public ForceUnitType() : base("newton")
		{
		}
	}

	/// <summary>
	/// The LinearUnitType defines the units to be used in the expression of length values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class LinearUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of length.
		/// If the element is used, its value must be meter.
		/// </summary>
		public LinearUnitType() : base("meter")
		{
		}
	}

	/// <summary>
	/// The MassUnitType defines the units to be used in the expression of mass values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class MassUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of mass.
		/// If the element is used, its value must be kiligram.
		/// </summary>
		public MassUnitType() : base("kilogram")
		{
		}
	}

	/// <summary>
	/// The PressureUnitType defines the units to be used in the expression	of pressure values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class PressureUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of pressure.
		/// If the element is used, its value must be pascal.
		/// </summary>
		public PressureUnitType() : base("pascal")
		{
		}
	}

	/// <summary>
	/// The SpeedUnitType defines the units to be used in the expression of	speed values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class SpeedUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of speed.
		/// If the element is used, its value must be meter per second.
		/// </summary>
		public SpeedUnitType() : base("meter per second")
		{
		}
	}

	/// <summary>
	/// The TemperatureUnitType defines the units to be used in the	expression of temperature values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class TemperatureUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of temperature.
		/// If the element is used, its value must be meter per kelvin.
		/// </summary>
		public TemperatureUnitType() : base("kelvin")
		{
		}
	}

	/// <summary>
	/// The TimeUnitType defines the units to be used in the expression of time values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class TimeUnitType : UnitBaseType
	{
		/// <summary>
		/// The optional SIUnitName element is the name of the SI unit of time.
		/// If the element is used, its value must be meter per second.
		/// </summary>
		public TimeUnitType() : base("second")
		{
		}
	}
}
