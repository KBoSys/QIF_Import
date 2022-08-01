/*! \file PartNoteSetType.cs
	\brief a collection of all part notes and standard notes presented in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks a collection of all part notes and standard notes presented in the CAD scene./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PartNoteSetType : ArrayBaseType<PartNoteType>
    {
        /// <remarks Each PartNote element is a part note./>
        [System.Xml.Serialization.XmlElementAttribute("PartNote")]
        public PartNoteType[] Items => base.itemsField;
    }
}
