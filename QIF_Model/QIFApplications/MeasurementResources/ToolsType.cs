/*! \file ToolsType.cs
	\brief Defines a list of tools (measurement device tool components with sensors)

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
	/// <remarks The ToolsType defines a list of tools (measurement device tool	components with sensors)./>
	public class ToolsType
	{
		/// <remarks Each Tool element gives information about a measurement device tool. />
		/// substitutionGroup="ToolWithIntegratedSensor">
		[XmlElement("ToolWithLVDTSensor", Type = typeof(ToolWithLVDTSensorType))]
		[XmlElement("ToolWithCapacitiveSensor", Type = typeof(ToolWithCapacitiveSensorType))]
		[XmlElement("ToolWithEddyCurrentSensor", Type = typeof(ToolWithEddyCurrentSensorType))]
		[XmlElement("ToolWithConfocalChromaticSensor", Type = typeof(ToolWithConfocalChromaticSensorType))]
		[XmlElement("ToolWithDrawWireSensor", Type = typeof(ToolWithDrawWireSensorType))]
		[XmlElement("ToolWithMagnetoInductiveSensor", Type = typeof(ToolWithMagnetoInductiveSensorType))]
		[XmlElement("ToolWithDVRTSensor", Type = typeof(ToolWithDVRTSensorType))]
		[XmlElement("ToolWithLaserTriangulationSensor", Type = typeof(ToolWithLaserTriangulationSensorType))]
		[XmlElement("ToolWithStructuredLightSensor", Type = typeof(ToolWithStructuredLightSensorType))]
		[XmlElement("ToolWithUltrasonicSensor", Type = typeof(ToolWithUltrasonicSensorType))]
		[XmlElement("ToolWithSimpleTactileProbeSensor", Type = typeof(ToolWithSimpleTactileProbeSensorType))]
		[XmlElement("ToolWithComplexTactileProbeSensor", Type = typeof(ToolWithComplexTactileProbeSensorType))]
		[XmlElement("ToolWithCCDCameraSensor", Type = typeof(ToolWithCCDCameraSensorType))]

		[XmlElement("ToolWithDetachableSensors", Type = typeof(ToolWithDetachableSensorsType))]
		public ToolBaseType[] Tools { get; set; }

		/// <remarks The required n attribute is the number of tools in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Tools.Length;
		}
	}

	/// <remarks The abstract ToolBaseType defines the base type for a measurement device that may be mounted on a CMM./>
	public abstract class ToolBaseType : MeasurementResourceBaseType
	{
	}

	/// <remarks The ToolWithDetachableSensorsType defines a tool with detachable sensors./>
	public class ToolWithDetachableSensorsType : ToolBaseType
	{
		/// <remarks The optional SensorIds element is a list of the QIF ids of sensors mounted on the tool./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType SensorIds { get; set; }
	}

	/// <remarks The abstract ToolWithIntegratedSensorBaseType defines the base type
	/// for a tool with an integrated sensor.This is the parent type for
	/// tool types with specific types of integrated sensor./>
	public abstract class ToolWithIntegratedSensorBaseType : ToolBaseType
	{
	}

	/// <remarks />
	public class ToolWithLVDTSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithCapacitiveSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithEddyCurrentSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithConfocalChromaticSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithDrawWireSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithMagnetoInductiveSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithDVRTSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithLaserTriangulationSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithStructuredLightSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithUltrasonicSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithSimpleTactileProbeSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithComplexTactileProbeSensorType : ToolWithIntegratedSensorBaseType
	{
	}

	/// <remarks />
	public class ToolWithCCDCameraSensorType : ToolWithIntegratedSensorBaseType
	{
	}
}
