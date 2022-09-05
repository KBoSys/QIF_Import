/*! \file FixturesType.cs
	\brief Defines a list of fixtures

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The FixturesType defines a list of fixtures. </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class FixturesType : ArrayBaseType<FixtureType>
    {
        /// <remarks> Each Fixture element gives information about a fixture. </remarks>
        [XmlElement("Fixture", Type = typeof(FixtureType))]
        public FixtureType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The FixtureType defines a fixture measurement resource. </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class FixtureType : MeasurementResourceBaseType
    {

    }
}
