/*! \file DetachableSensorsType.cs
	\brief Defines a list of detachable sensors.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.MeasurementResources
{
	/// <remarks The DetachableSensorsType defines a list of detachable sensors./>
	public class DetachableSensorsType
	{
		/// <remarks Each DetachableSensor element is a detachable sensor that may or may not be mounted on a tool./>
		[XmlElement("SimpleTactileProbeSensor", Type = typeof(SimpleTactileProbeSensorType))]
		[XmlElement("ComplexTactileProbeSensor", Type = typeof(ComplexTactileProbeSensorType))]
		[XmlElement("DetachableCapacitiveSensor", Type = typeof(CapacitiveSensorType))]
		[XmlElement("DetachableLVDTSensor", Type = typeof(LinearVariableDifferentialTransformerSensorType))]
		public DetachableSensorBaseType[] DetachableSensors { get; set; }

		/// <remarks The required n attribute is the number of detachable sensors in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.DetachableSensors.Length;
		}
	}

	/// <remarks The abstract DetachableSensorBaseType is the parent type of more specific types of detachable sensor./>
	public abstract class DetachableSensorBaseType : SensorType
	{
	}

	/// <remarks The CapacitiveSensorType defines a capacitive displacement sensor. />
	public class CapacitiveSensorType : DetachableSensorBaseType
	{
		/// <remarks The optional MinOperatingVoltage element is the minimum
		/// voltage at which the capacitive displacement sensor could produce usable measurements./>
		[XmlElement(IsNullable = true)]
		public Units.UserDefinedUnitValueType MinOperatingVoltage { get; set; }

		/// <remarks The optional MaxOperatingVoltage element is the maximum
		/// voltage at which the capacitive displacement sensor could produce usable measurements./>
		[XmlElement(IsNullable = true)]
		public Units.UserDefinedUnitValueType MaxOperatingVoltage { get; set; }

		/// <remarks The optional MinMeasuringDistance element is the minimum
		/// measuring distance of the capacitive displacement sensor./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType MinMeasuringDistance { get; set; }

		/// <remarks The optional MaxMeasuringDistance element is the maximum
		/// measuring distance of the capacitive displacement sensor./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType MaxMeasuringDistance { get; set; }

		/// <remarks The optional TemperatureStability element is the
		/// temperature stability of the capacitive displacement sensor./>
		[XmlElement(IsNullable = true)]
		public Units.UserDefinedUnitValueType TemperatureStability { get; set; }

		/// <remarks The optional MinimumTargetDiameter element is the
		/// minimum diameter of the target to be measured./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType MinimumTargetDiameter { get; set; }

		/// <remarks The optional HousingMaterial element is the type of
		/// material used for the capacitive displacement sensor./>
		[XmlElement(IsNullable = true)]
		public string HousingMaterial { get; set; }

		/// <remarks The optional Mounting element is the type of mounting
		/// used for the capacitive displacement sensor./>
		[XmlElement(IsNullable = true)]
		public string Mounting { get; set; }
	}

	/// <remarks The LinearVariableDifferentialTransformerEnumType enumerates values
	/// that describe different types of Linear Variable Differential Transformer(LVDT) />
	public enum LinearVariableDifferentialTransformerEnumType
	{
		AC_LINEAR_VARIABLE_DIFFERENTIAL_TRANSFORMER,
		DC_LINEAR_VARIABLE_DIFFERENTIAL_TRANSFORMER,
	}

	/// <remarks The LinearVariableDifferentialTransformerSensorType defines a Linear
	/// Variable Differential Transformer(LVDT) sensor. />
	public class LinearVariableDifferentialTransformerSensorType : DetachableSensorBaseType
	{
		/// <remarks The optional TypeOfLinearVariableDifferentialTransformer
		/// element is the type of Linear Variable Differential	Transformer(LVDT) sensor. />
		[XmlElement(IsNullable = true)]
		public LinearVariableDifferentialTransformerEnumType TypeOfLinearVariableDifferentialTransformerMounting { get; set; }

		/// <remarks The optional MinMeasuringDistance element is the minimum measuring distance. />
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType MinMeasuringDistance { get; set; }

		/// <remarks The optional MaxMeasuringDistance element is the maximum measuring distance. />
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType MaxMeasuringDistance { get; set; }

		/// <remarks The optional TemperatureStability element is the
		/// temperature stability of the capacitive displacement sensor./>
		[XmlElement(IsNullable = true)]
		public Units.UserDefinedUnitValueType TemperatureStability { get; set; }

		/// <remarks The optional ExcitationFrequency element is the input
		/// frequency for a linear variable differential transformer sensor./>
		[XmlElement(IsNullable = true)]
		public Units.UserDefinedUnitValueType ExcitationFrequency { get; set; }

		/// <remarks The optional ExcitationAmplitude element is the
		/// amplitude of excitation in a linear variable differential transformer sensor./>
		[XmlElement(IsNullable = true)]
		public Units.UserDefinedUnitValueType ExcitationAmplitude { get; set; }

		/// <remarks The optional Diameter element is the diameter of the
		/// rod connected to displacing part./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType Diameter { get; set; }

		/// <remarks The optional ShockTolerance element is the level shock
		/// tolerance for a linear variable differential transformer./>
		[XmlElement(IsNullable = true)]
		public Units.UserDefinedUnitValueType ShockTolerance { get; set; }

		/// <remarks The optional VibrationTolerance element is the level
		/// of vibration tolerance for a linear variable differential transformer./>
		[XmlElement(IsNullable = true)]
		public Units.UserDefinedUnitValueType VibrationTolerance { get; set; }

		/// <remarks The optional HousingMaterial element is the type of
		/// material used for the capacitive displacement sensor./>
		[XmlElement(IsNullable = true)]
		public string HousingMaterial { get; set; }

		/// <remarks The optional ElectronicDescription element describes the
		/// electronic parts of a linear variable differential transformer./>
		[XmlElement(IsNullable = true)]
		public string ElectronicDescription { get; set; }
	}
}