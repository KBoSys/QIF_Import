/*! \file UnitCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured unit characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaCharacteristicMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForceCharacteristicMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MassCharacteristicMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PressureCharacteristicMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpeedCharacteristicMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemperatureCharacteristicMeasurementBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCharacteristicMeasurementBaseType))]
    public abstract class UnitCharacteristicMeasurementBaseType<T> : CharacteristicMeasurementBaseType
    {
        /// <remarks The optional Value element is the measured value of the characteristic./>
        public T Value { get; set; }

        /// <remarks The optional MaxValue element is the maximum of the measured value when reported./>
        public T MaxValue { get; set; }

        /// <remarks The optional MinValue element is the minimum of the measured value when reported./>
        public T MinValue { get; set; }
    }
}
