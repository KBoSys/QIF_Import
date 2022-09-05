/*! \file QPIdFullReferenceType.cs

        The QIFReferenceType defines a reference to a QIF id that may be in
        the same file as the reference or may be in an identified external
        file. In order to ensure that each reference refers to an object of
        the correct type, where possible, each reference is covered by an
        appropriate key/keyref constraint.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class QPIdFullReferenceType
    {
        //! The ItemQPId is the QPId of an item.
        [XmlElement]
        public QPIdReferenceType? ItemQPId { get; set; }

        //! Each optional DocumentQPId is the QPId of a QIFDocument in which the item is found.
        [XmlElement]
        public QPIdReferenceType[]? DocumentQPId { get; set; }
    }
}
