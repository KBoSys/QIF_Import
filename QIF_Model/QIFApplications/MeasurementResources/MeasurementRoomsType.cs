/*! \file MeasurementRoomsType.cs
	\brief Defines a list of measurement rooms.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks The MeasurementRoomsType defines a list of measurement rooms./>
    public class MeasurementRoomsType
    {
        /// <remarks Each MeasurementRoom element gives information about a measurement room./>
        [XmlElement("MeasurementRoom", Type = typeof(MeasurementRoomType))]
        public MeasurementRoomType[] MeasurementRooms { get; set; }

        /// <remarks The required n attribute gives the number of measurement rooms in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.MeasurementRooms.Length;
            set { }
        }
    }

    /// <remarks The MeasurementRoomType defines a room in which measurement may be	done./>
    public class MeasurementRoomType : MeasurementResourceBaseType
    {
        /// <remarks The TemperatureRangeMin element gives the minimum
        /// temperature that the room can maintain while staying within
        /// the temperature control limits./>
        [XmlElement(IsNullable = false)]
        public TemperatureType TemperatureRangeMin { get; set; }

        /// <remarks The TemperatureRangeMax element gives the maximum
        /// temperature that the room can maintain while staying within
        /// the temperature control limits./>
        [XmlElement(IsNullable = false)]
        public TemperatureType TemperatureRangeMax { get; set; }

        /// <remarks This is an amount below any in-range temperature that the
        /// room is guaranteed not exceed.This must be a positive value./>
        [XmlElement(IsNullable = false)]
        public TemperatureType TemperatureControlMin { get; set; }

        /// <remarks This is an amount above any in-range temperature that the room is guaranteed not exceed./>
        [XmlElement(IsNullable = false)]
        public TemperatureType TemperatureControlMax { get; set; }

        /// <remarks The RelativeHumidityRangeMin element gives the minimum
        /// relative humidity that the room can maintain while staying
        /// within the humidity control limits./>
        [XmlElement(IsNullable = false)]
        public QIFLibrary.Primitives.FractionType RelativeHumidityRangeMin { get; set; }

        /// <remarks The RelativeHumidityRangeMax element gives the maximum
        /// relative humidity that the room can maintain while staying
        /// within the humidity control limits./>
        [XmlElement(IsNullable = false)]
        public QIFLibrary.Primitives.FractionType RelativeHumidityRangeMax { get; set; }

        /// <remarks This is an amount below any in-range relative humidity that
        /// the room is guaranteed not exceed.This must be a positive value./>
        [XmlElement(IsNullable = false)]
        public QIFLibrary.Primitives.FractionType RelativeHumidityControlMin { get; set; }

        /// <remarks This is an amount above any in-range relative humidity that
        /// the room is guaranteed not exceed./>
        [XmlElement(IsNullable = false)]
        public QIFLibrary.Primitives.FractionType RelativeHumidityControlMax { get; set; }
    }
}
