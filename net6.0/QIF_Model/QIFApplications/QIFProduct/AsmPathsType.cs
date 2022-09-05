/*! \file AsmPathsType.cs
    \brief The AsmPathsType defines a list of one or more assembly paths.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks> The AsmPathType defines information about assembly path, this path is used for identification of an object inside an assembly.</remarks>
    public class AsmPathType : QIFIdTypeBase
    {
        /// <remarks> The ComponentIds element is an array of identifiers of the
        /// scene components which contain this entity.This array shows
        /// the "path" from the root to the parent component.The id of the parent component must be the last element of this array.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceType? ComponentIds { get; set; }
    }

    /// <remarks> The AsmPathsType defines a list of one or more assembly paths.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AsmPathsType : ArrayBaseType<AsmPathType>
    {
        /// <remarks> Each Part element is a part which can be used by a number of components(instances of the part).</remarks>
        [XmlElement(ElementName = "AsmPath", Type = typeof(AsmPathType))]
        public AsmPathType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
