﻿/*! \file ValueTypes.cs
    \brief Value Types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Units
{
	/// <summary>
	/// The NonNegativeDecimalType is a Decimal that is not negative i.e. >= 0.0.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class NonNegativeDecimalType : DecimalType
	{
		public NonNegativeDecimalType()
		{
		}
		private NonNegativeDecimalType(System.Decimal value)
		{
			base._value = Math.Abs(value);
		}
		public static implicit operator NonNegativeDecimalType(System.Decimal value)
		{
			return new NonNegativeDecimalType(value);
		}
	}

	/// <summary>
	/// The PositiveDecimalType is a Decimal that is positive i.e. > 0.0.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class PositiveDecimalType : NonNegativeDecimalType
	{
		public PositiveDecimalType()
		{
		}
		public PositiveDecimalType(System.Decimal value)
		{
			if (value == 0)
			{
				throw new System.InvalidOperationException("The value cannot be zero!");
			}
			base._value = Math.Abs(value);
		}
		public static implicit operator PositiveDecimalType(System.Decimal value)
		{
			return new PositiveDecimalType(value);
		}
	}

	public class NonNegativeInteger : UInt32Type
	{
	}

	/*! 
		A SpecifiedDecimalType defines an xs:decimal type with two optional
		attributes: significantFigures and decimalPlaces.

		The optional decimalPlaces attribute represents the number of
		places to the right of the decimal point to which the xs:decimal is
		specified. The actual number of decimal places used may be greater
		or less than the decimalPlaces attribute. If the value has more
		decimal places, the extra ones are meaningless. If the value has
		fewer decimal places, the missing decimal places are implicitly
		zero.

		A value of xs:decimal type stored in an XML instance file might not
		have the same number of decimal places as the original input
		number.

		The number of decimal place may be truncated because of trailing
		zeros. For example a number like 10.000 from a part print might
		appear in an instance file as {Value}10{/Value} -- using '{' and
		'}' here instead of chevrons as would be used in an instance file.

		The xs:decimal representation of a value may have many extra
		decimal places because of intrinsic computer limitations in
		representing floating point numbers. For example a number like 3.15
		might appear in an instance file as 3.14999999999998.

		In both cases the original format of the value can be communicated
		using the optional decimalPlaces attribute: {Value
		decimalPlaces="3"}10{/Value} means 10.000 {Value
		decimalPlaces="2"}3.1499999999998{/Value} means 3.15. The value is
		to be rounded to the number of decimal places indicated with the
		decimalPlaces attribute.

		The optional significantFigures attribute represents the number of
		significant figures with which the xs:decimal is specified. The
		actual number of digits may be greater or less than the
		significantFigures attribute.

		Unlike decimalPlaces, the significantFigures value does not affect
		the format of a value, but rather its meaning. A value becomes
		uncertain when the number of significant figures is exceeded. A
		value of 2.3456789 with 4 significant figures indicates that the
		real value is uncertain and lies anywhere in the range
		2.345000... to 2.345999...
	 */
	[System.SerializableAttribute()]
	public class SpecifiedDecimalType : DecimalType
	{
		public SpecifiedDecimalType() { }
		protected SpecifiedDecimalType(decimal value) : base(value) { }

		[XmlElement("decimalPlaces")]
		public NonNegativeInteger DecimalPlaces { get; set; }

		[XmlElement("significantFigures")]
		public NonNegativeInteger SignificantFigures { get; set; }
	}

	/// <summary>
	/// The MeasuredDecimalType defines a SpecifiedDecimalType with two
	/// additional optional attributes: meanError and combinedUncertainty.
	/// These attributes should either both be used or both be omitted.
	/// </summary>
	[System.SerializableAttribute()]
	public class MeasuredDecimalType : SpecifiedDecimalType
	{
		/// <summary>
		/// The optional combinedUncertainty attribute is a value
		/// expressing the combined uncertainty assigned to the SpecifiedDecimalType.
		/// </summary>
		[XmlElement("combinedUncertainty")]
		public NonNegativeDecimalType CombinedUncertainty { get; set; }

		/// <summary>
		/// The optional meanError attribute is a value expressing the
		/// mean error assigned to the SpecifiedDecimalType.
		/// </summary>
		[XmlElement("meanError")]
		public NonNegativeDecimalType MeanError { get; set; }
	}

	/// <summary>
	/// The AngularValueType is a SpecifiedDecimalType with an optional
	/// angularUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when an angle value is given, the unit type is the AngularUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and radians if not.
	/// </summary>
	public class AngularValueType : SpecifiedDecimalType
    {
		public AngularValueType(decimal value) : base(value) { }

		/// <summary>
		/// The optional angularUnit attribute defines the UnitName
		/// for the AngularValueType.
		/// </summary>
		[XmlElement("angularUnit")]
        public AngularUnitType AngularUnit { get; set; }

		/// Implicit conversion from System.Decimal to DecimalType 
		public static implicit operator AngularValueType(decimal value)
		{
			return new AngularValueType(value);
		}
		/// Implicit conversion to a System.Decimal.
		public static implicit operator decimal(AngularValueType alias)
		{
			return alias;
		}
	}

	/// <summary>
	/// The MeasuredAngularValueType is an MeasuredDecimalType with an
	/// optional angularUnit attribute that identifies the unit being used
	/// by its UnitName.If no value for the attribute is given in an
	/// instance file when an angle value is given, the unit type is the
	/// AngularUnit specified in the PrimaryUnits element of a FileUnits
	/// element, if that specification exists, and radians if not.
	/// </summary>
	public class MeasuredAngularValueType : MeasuredDecimalType
    {
        /// <summary>
        /// The optional angularUnit attribute defines the UnitName
        /// for the MeasuredAngularValueType.
        /// </summary>
        [XmlElement("angularUnit")]
        public AngularUnitType AngularUnit { get; set; }
    }

    /// <summary>
    /// The AreaValueType is a SpecifiedDecimalType with an optional
    /// areaUnit attribute that identifies the unit being used by its
    /// UnitName.If no value for the attribute is given in an instance
    /// file when an area value is given, the unit type is the AreaUnit
    /// specified in the PrimaryUnits element of a FileUnits element, if
    /// that specification exists, and square meters if not.
    /// </summary>
    public class AreaValueType : SpecifiedDecimalType
    {
        /// <summary>
        /// The optional areaUnit attribute defines the UnitName for
        /// the AreaValueType.
        /// </summary>
        [XmlElement("areaUnit")]
        public AreaUnitType AreaUnit { get; set; }
    }

    /// <summary>
    /// The MeasuredAreaValueType is an MeasuredDecimalType with an optional
    /// areaUnit attribute that identifies the unit being used by its
    /// UnitName.If no value for the attribute is given in an instance
    /// file when an area value is given, the unit type is the AreaUnit
    /// specified in the PrimaryUnits element of a FileUnits element, if
    /// that specification exists, and square meters if not.
    /// </summary>
    public class MeasuredAreaValueType : MeasuredDecimalType
    {
        /// <summary>
        /// The optional areaUnit attribute defines the unit used by MeasuredAreaValueType.
        /// </summary>
        [XmlElement("areaUnit")]
        public AreaUnitType AreaUnit { get; set; }
    }

	/// <summary>
	/// The ForceValueType is a SpecifiedDecimalType with an optional
	/// forceUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when a force value is given, the unit type is the ForceUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and newtons if not.
	/// </summary>
	public class ForceValueType : SpecifiedDecimalType
	{
		/// <summary>
		/// The optional forceUnit attribute defines the UnitName for the ForceValueType.
		/// </summary>
		[XmlElement("forceUnit")]
		public ForceUnitType ForceUnit { get; set; }
	}

	/// <summary>
	/// The MeasuredForceValueType is an MeasuredDecimalType with an
	/// optional forceUnit attribute that identifies the unit being used by
	/// its UnitName.If no value for the attribute is given in an instance
	/// file when a force value is given, the unit type is the ForceUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and newtons if not.
	/// </summary>
	public class MeasuredForceValueType : MeasuredDecimalType
	{
		/// <summary>
		/// The optional forceUnit attribute defines the unit used by MeasuredForceValueType.
		/// </summary>
		[XmlElement("forceUnit")]
		public ForceUnitType ForceUnit { get; set; }
	}

	/// <summary>
	/// The LinearValueType is a SpecifiedDecimalType with an optional
	/// linearUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when a length value is given, the unit type is the LinearUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and meters if not.
	/// </summary>
	public class LinearValueType : SpecifiedDecimalType
	{
		/// <summary>
		/// The optional linearUnit attribute defines the UnitName for the LinearValueType.
		/// </summary>
		[XmlElement("linearUnit")]
		public LinearUnitType LinearUnit { get; set; }
	}

	/// <summary>
	/// The LinearDualValueType is a SpecifiedDecimalType with a required
	/// linearUnit attribute that identifies the unit being used by its	UnitName.
	/// </summary>
	public class LinearDualValueType : LinearValueType
	{
	}

	/// <summary>
	/// The MeasuredLinearValueType is an MeasuredDecimalType with an
	/// optional linearUnit attribute that identifies the unit being used
	/// by its UnitName.If no value for the attribute is given in an
	/// instance file when a length value is given, the unit type is the
	/// LinearUnit specified in the PrimaryUnits element of a FileUnits
	/// element, if that specification exists, and meters if not.
	/// </summary>
	public class MeasuredLinearValueType : MeasuredDecimalType
	{
		/// <summary>
		/// The optional forceUnit attribute defines the unit used by MeasuredForceValueType.
		/// </summary>
		[XmlElement("linearUnit")]
		public LinearUnitType LinearUnit { get; set; }
	}

	/// <summary>
	/// The MassValueType is a SpecifiedDecimalType with an optional
	/// massUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when a mass value is given, the unit type is the MassUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and kilograms if not.
	/// </summary>
	public class MassValueType : SpecifiedDecimalType
	{
		/// <summary>
		/// The optional massUnit attribute defines the UnitName for the MassValueType.
		/// </summary>
		[XmlAttributeAttribute("massUnit")]
		public MassUnitType MassUnit { get; set; }
	}

	/// <summary>
	/// The MeasuredMassValueType is an MeasuredDecimalType with an optional
	/// massUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when a mass value is given, the unit type is the MassUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and kilograms if not.
	/// </summary>
	public class MeasuredMassValueType : MeasuredDecimalType
	{
		/// <summary>
		/// The optional massUnit attribute defines the unit used by MeasuredMassValueType.
		/// </summary>
		[XmlElement("massUnit")]
		public MassUnitType MassUnit { get; set; }
	}

	/// <summary>
	/// The PressureValueType is a SpecifiedDecimalType with an optional
	/// pressureUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when a pressure value is given, the unit type is the
	/// PressureUnit specified in the PrimaryUnits element of a FileUnits
	/// element, if that specification exists, and pascals if not.
	/// </summary>
	public class PressureValueType : SpecifiedDecimalType
	{
		/// <summary>
		/// The optional pressureUnit attribute defines the UnitName for the PressureValueType.
		/// </summary>
		[XmlElement("pressureUnit")]
		public PressureUnitType PressureUnit { get; set; }
	}

	/// <summary>
	/// The MeasuredPressureValueType is an MeasuredDecimalType with an
	/// optional pressureUnit attribute that identifies the unit being used
	/// by its UnitName.If no value for the attribute is given in an
	/// instance file when a pressure value is given, the unit type is the
	/// PressureUnit specified in the PrimaryUnits element of a FileUnits
	/// element, if that specification exists, and pascals if not.
	/// </summary>
	public class MeasuredPressureValueType : MeasuredDecimalType
	{
		/// <summary>
		/// The optional massUnit attribute defines the unit used by MeasuredMassValueType.
		/// </summary>
		[XmlElement("pressureUnit")]
		public PressureUnitType PressureUnit { get; set; }
	}

	/// <summary>
	/// The SpeedValueType is a SpecifiedDecimalType with an optional
	/// speedUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when a speed value is given, the unit type is the SpeedUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and meters per second if not.
	/// </summary>
	public class SpeedValueType : SpecifiedDecimalType
	{
		/// <summary>
		/// The optional speedUnit attribute defines the UnitName for the SpeedValueType.
		/// </summary>
		[XmlElement("speedUnit")]
		public SpeedUnitType SpeedUnit { get; set; }
	}

	/// <summary>
	/// The MeasuredSpeedValueType is an MeasuredDecimalType with an
	/// optional speedUnit attribute that identifies the unit being used by
	/// its UnitName.If no value for the attribute is given in an instance
	/// file when a speed value is given, the unit type is the SpeedUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and meters per second if not.
	/// </summary>
	public class MeasuredSpeedValueType : MeasuredDecimalType
	{
		/// <summary>
		/// The optional speedUnit attribute defines the UnitName for the MeasuredSpeedValueType.
		/// </summary>
		[XmlElement("speedUnit")]
		public SpeedUnitType SpeedUnit { get; set; }
	}

	/// <summary>
	/// The TemperatureValueType is a SpecifiedDecimalType with an
	/// optional temperatureUnit attribute that identifies the unit being
	/// used by its UnitName.If no value for the attribute is given in an
	/// instance file when a temperature value is given, the unit type is
	/// the TemperatureUnit specified in the PrimaryUnits element of a
	/// FileUnits element, if that specification exists, and kelvin if not.
	/// </summary>
	public class TemperatureValueType : SpecifiedDecimalType
	{
		/// <summary>
		/// The optional speedUnit attribute defines the UnitName for the SpeedValueType.
		/// </summary>
		[XmlElement("temperatureUnit")]
		public TemperatureUnitType TemperatureUnit { get; set; }
	}

	/// <summary>
	/// The MeasuredTemperatureValueType is an MeasuredDecimalType with an
	/// optional temperatureUnit attribute that identifies the unit being
	/// used by its UnitName.If no value for the attribute is given in an
	/// instance file when a temperature value is given, the unit type is
	/// the TemperatureUnit specified in the PrimaryUnits element of a
	/// FileUnits element, if that specification exists, and kelvin if not.
	/// </summary>
	public class MeasuredTemperatureValueType : MeasuredDecimalType
	{
		/// <summary>
		/// The optional temperatureUnit attribute defines the UnitName for the TemperatureValueType.
		/// </summary>
		[XmlElement("temperatureUnit")]
		public TemperatureUnitType TemperatureUnit { get; set; }
	}

	/// <summary>
	/// The TimeValueType is a SpecifiedDecimalType with an optional
	/// timeUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when a time value is given, the unit type is the TimeUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and seconds if not.
	/// </summary>
	public class TimeValueType : SpecifiedDecimalType
	{
		/// <summary>
		/// The optional timeUnit attribute defines the UnitName for the TimeValueType.
		/// </summary>
		[XmlElement("timeUnit")]
		public TimeUnitType TimeUnit { get; set; }
	}

	/// <summary>
	/// The MeasuredTimeValueType is an MeasuredDecimalType with an optional
	/// timeUnit attribute that identifies the unit being used by its
	/// UnitName.If no value for the attribute is given in an instance
	/// file when a time value is given, the unit type is the TimeUnit
	/// specified in the PrimaryUnits element of a FileUnits element, if
	/// that specification exists, and seconds if not.
	/// </summary>
	public class MeasuredTimeValueType : MeasuredDecimalType
	{
		/// <summary>
		/// The optional timeUnit attribute defines the UnitName for the TimeValueType.
		/// </summary>
		[XmlElement("timeUnit")]
		public TimeUnitType TimeUnit { get; set; }
	}
}
