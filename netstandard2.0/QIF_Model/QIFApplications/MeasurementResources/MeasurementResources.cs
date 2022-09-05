/*! \file MeasurementResources.cs
	\brief Defines a set of measurement resources..

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> defines a set of measurement resources.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class MeasurementResourcesType
    {
        /// <remarks> The optional Version element uniquely identifies the version information of this QIF Resources instance.</remarks>
        [XmlElement()]
        public QIFLibrary.IntermediatesPMI.VersionType Version { get; set; }

        /// <remarks> The optional Fixtures element is a list of fixtures.</remarks>
        [XmlElement()]
        public FixturesType Fixtures { get; set; }

        /// <remarks> The optional MeasurementRooms element is a list of measurement rooms.</remarks>
        [XmlElement()]
        public MeasurementRoomsType MeasurementRooms { get; set; }

        /// <remarks> The optional MeasurementDevices element is a list of measurement devices.</remarks>
        [XmlElement()]
        public MeasurementDevicesType MeasurementDevices { get; set; }

        /// <remarks> The optional DetachableSensors element is a list of detachable sensors.</remarks>
        [XmlElement()]
        public DetachableSensorsType DetachableSensors { get; set; }

        /// <remarks> The optional Tools element is a list of tools.</remarks>
        [XmlElement()]
        public ToolsType Tools { get; set; }
    }

}
