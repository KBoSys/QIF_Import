/*! \file ToolsType.cs
	\brief Defines a list of tools (measurement device tool components with sensors)

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The ToolsType defines a list of tools (measurement device tool	components with sensors).</remarks>
    public class ToolsType
    {
        /// <remarks> Each Tool element gives information about a measurement device tool. </remarks>
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

        /// <remarks> The required n attribute is the number of tools in the list.</remarks>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.Tools.Length;
            set { }
        }
    }

    /// <remarks> The abstract ToolBaseType defines the base type for a measurement device that may be mounted on a CMM.</remarks>
    public abstract class ToolBaseType : MeasurementResourceBaseType
    {
    }

    /// <remarks> The ToolWithDetachableSensorsType defines a tool with detachable sensors.</remarks>
    public class ToolWithDetachableSensorsType : ToolBaseType
    {
        /// <remarks> The optional SensorIds element is a list of the QIF ids of sensors mounted on the tool.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceType? SensorIds { get; set; }
    }

    /// <remarks> The abstract ToolWithIntegratedSensorBaseType defines the base type
    /// for a tool with an integrated sensor.This is the parent type for
    /// tool types with specific types of integrated sensor.</remarks>
    public abstract class ToolWithIntegratedSensorBaseType : ToolBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithLVDTSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithCapacitiveSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithEddyCurrentSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithConfocalChromaticSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithDrawWireSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithMagnetoInductiveSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithDVRTSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithLaserTriangulationSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithStructuredLightSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithUltrasonicSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithSimpleTactileProbeSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithComplexTactileProbeSensorType : ToolWithIntegratedSensorBaseType
    {
    }

    /// <remarks> </remarks>
    public class ToolWithCCDCameraSensorType : ToolWithIntegratedSensorBaseType
    {
    }
}
