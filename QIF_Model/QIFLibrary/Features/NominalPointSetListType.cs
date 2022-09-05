/*! \file NominalPointSetListType.cs
    \brief Defines a list of all nominal target measurement point sets

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Nominals;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features
{
    /// <remarks> The NominalPointSetListType defines a list of all nominal
    /// target measurement point sets to be referenced by feature nominals or feature items.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NominalPointSetListType : ArrayBaseType<PointSetNominalType>
    {
        /// <remarks> Each NominalPointSet element is a set of nominal target measurement points.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("NominalPointSet")]
        public PointSetNominalType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
