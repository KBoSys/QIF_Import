/*! \file TemperaturesType.cs
	\brief Defines a list of temperatures.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The TemperaturesType defines a list of temperatures.</remarks>
    public class TemperaturesType : ArrayBaseType<TemperatureType>
    {
        /// <remarks> Each Temperature element is a temperature noted for a machine.</remarks>
        [XmlElement("Temperature", Type = typeof(TemperatureType))]
        public TemperatureType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The TemperatureType defines information about a temperature measurement.</remarks>
    public class TemperatureType
    {
        /// <remarks> The optional Attributes element contains user defined attributes (typified, binary array, or XML structured).</remarks>
        [XmlElement()]
        public QIFLibrary.Primitives.AttributesType Attributes { get; set; }

        /// <remarks> The Temperature element is the temperature value.</remarks>
        [XmlElement(IsNullable = false)]
        public QIFLibrary.Units.TemperatureValueType Temperature { get; set; }

        /// <remarks> The optional TimeStamp element is a time and date associated with the temperature value.</remarks>
        [XmlElement()]
        public DateTime TimeStamp { get; set; }
    }
}
