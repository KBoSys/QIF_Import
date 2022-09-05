/*! \file QualificationsType.cs
	\brief Defines a list of sensor qualifications.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The QualificationsType defines a list of sensor qualifications.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class QualificationsType : ArrayBaseType<QualificationType>
    {
        /// <remarks> Each Qualification element gives information about a sensor qualification. </remarks>
        [XmlElement("Qualification", Type = typeof(QualificationType))]
        public QualificationType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The QualificationType defines how a measurement device has been qualified.</remarks>
    public class QualificationType : QIFLibrary.Primitives.AttributesTypeHolder
    {
        /// <remarks> The Description element is a description of the qualification.
        /// This may include items such as orientation information and environment information. </remarks>
        [XmlElement]
        public string? Description { get; set; }
    }
}
