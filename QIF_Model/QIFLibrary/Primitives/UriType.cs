/*! \file UriType.cs
    \brief Defines serializable UriType

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    public class UriType : IXmlSerializable
    {
        [XmlIgnore]
        public Uri URI { get; set; }

        #region Xml Serialization Infrastructure
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(URI.ToString());
        }

        public void ReadXml(XmlReader reader)
        {
            URI = (Uri)reader.ReadElementContentAs(typeof(Uri), null);
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return (null);
        }
        #endregion
    }
}
