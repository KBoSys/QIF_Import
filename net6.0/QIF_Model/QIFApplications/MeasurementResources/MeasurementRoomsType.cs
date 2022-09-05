/*! \file MeasurementRoomsType.cs
	\brief Defines a list of measurement rooms.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The MeasurementRoomsType defines a list of measurement rooms.</remarks>
    public class MeasurementRoomsType : ArrayBaseType<MeasurementRoomType>
    {
        /// <remarks> Each MeasurementRoom element gives information about a measurement room.</remarks>
        [XmlElement("MeasurementRoom", Type = typeof(MeasurementRoomType))]
        public MeasurementRoomType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The MeasurementRoomType defines a room in which measurement may be	done.</remarks>
    public class MeasurementRoomType : MeasurementResourceBaseType
    {
        /// <remarks> The TemperatureRangeMin element gives the minimum
        /// temperature that the room can maintain while staying within
        /// the temperature control limits.</remarks>
        [XmlElement]
        public TemperatureType? TemperatureRangeMin { get; set; }

        /// <remarks> The TemperatureRangeMax element gives the maximum
        /// temperature that the room can maintain while staying within
        /// the temperature control limits.</remarks>
        [XmlElement]
        public TemperatureType? TemperatureRangeMax { get; set; }

        /// <remarks> This is an amount below any in-range temperature that the
        /// room is guaranteed not exceed.This must be a positive value.</remarks>
        [XmlElement]
        public TemperatureType? TemperatureControlMin { get; set; }

        /// <remarks> This is an amount above any in-range temperature that the room is guaranteed not exceed.</remarks>
        [XmlElement]
        public TemperatureType? TemperatureControlMax { get; set; }

        /// <remarks> The RelativeHumidityRangeMin element gives the minimum
        /// relative humidity that the room can maintain while staying
        /// within the humidity control limits.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.FractionType? RelativeHumidityRangeMin { get; set; }

        /// <remarks> The RelativeHumidityRangeMax element gives the maximum
        /// relative humidity that the room can maintain while staying
        /// within the humidity control limits.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.FractionType? RelativeHumidityRangeMax { get; set; }

        /// <remarks> This is an amount below any in-range relative humidity that
        /// the room is guaranteed not exceed.This must be a positive value.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.FractionType? RelativeHumidityControlMin { get; set; }

        /// <remarks> This is an amount above any in-range relative humidity that
        /// the room is guaranteed not exceed.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.FractionType? RelativeHumidityControlMax { get; set; }
    }
}
