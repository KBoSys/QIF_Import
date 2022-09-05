/*! \file NotableEventsType.cs
	\brief Defines a list of notable events that might occur during an inspection.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <summary>
    /// The NotableEventsType defines a list of notable events that might
    /// occur during an inspection.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class NotableEventsType : ArrayBaseType<NotableEventType>
    {
        /// <summary>
        /// Each NotableEvent element gives information about a notable
        /// event that might occur during an inspection.
        /// </summary>
        [XmlElement(ElementName = "NotableEvent", Type = typeof(NotableEventType))]
        public NotableEventType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
