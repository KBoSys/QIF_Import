/*! \file EventTypes.cs
	\brief Defines events

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
    /// <summary>
    /// The EventBaseType is the abstract base type that defines events.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class EventBaseType : QIFIdTypeBase
    {
        public EventBaseType() { }

        //! The Description element is the description of the event.
        [XmlElement]
        public string Description { get; set; }
    }

    /// <summary>
    /// The NotableEventType defines an event that might occur during an
    /// inspection, any instance of which(1) should be reported as a
    /// NotedEventType if it occurs and the Active element is "true" or(2)
    /// should not be reported if it occurs and the active element is "false".
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class NotableEventType : EventBaseType
	{
        public NotableEventType() { }

        /// <summary>
        /// The Active element indicates whether the event should be
        /// reported.A value of "true" means an event of this type
        /// should be reported.A value of "false" means an event of
                /// this type should not be reported.
        /// </summary>
        [XmlElement]
        public bool Active { get; set; }
    }

    /// <summary>
    /// The NotedEventType defines an instance of an event that occurred
    /// during an inspection.It may correspond to some notable event type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class NotedEventType : EventBaseType
    {
        public NotedEventType() { }

        /// <summary>
        /// The SequenceNumber element is the sequence number of a
        /// noted event in a list of noted events. Sequence numbers of
        /// noted event instances should be assigned in chronological
        /// order(1, 2, 3, ...).
        /// </summary>
        [XmlElement]
        public NaturalType SequenceNumber { get; set; }

        /// <summary>
        /// The optional TimeOccurred element is the date and time at
        /// which the event occurred.
        /// </summary>
        [XmlElement]
        public DateTime TimeOccurred { get; set; }

        /// <summary>
        /// The optional NotableEventId element is the QIF id of a
        /// notable event type of which this noted event is an instance.
        /// </summary>
        [XmlElement]
        public Primitives.QIFReferenceType NotableEventId { get; set; }
    }
}
