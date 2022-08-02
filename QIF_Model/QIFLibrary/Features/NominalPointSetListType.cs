/*! \file NominalPointSetListType.cs
    \brief Defines a list of all nominal target measurement point sets

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Nominals;

namespace QIF_Model.QIFLibrary.Features
{
    /// <remarks The NominalPointSetListType defines a list of all nominal
    /// target measurement point sets to be referenced by feature nominals or feature items./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NominalPointSetListType
    {
        /// <remarks Each NominalPointSet element is a set of nominal target measurement points./>
        [System.Xml.Serialization.XmlElementAttribute("NominalPointSet")]
        public PointSetNominalType[] Items { get; set; }

        /// <remarks The required n attribute is the number of nominal point sets in this list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
