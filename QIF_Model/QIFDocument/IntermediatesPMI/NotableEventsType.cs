/*! \file NotableEventsType.cs
	\brief Defines a list of notable events that might occur during an inspection.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
	/// <summary>
	/// The NotableEventsType defines a list of notable events that might
	/// occur during an inspection.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public  class NotableEventsType
	{
		public NotableEventsType() { }

		/// <summary>
		/// Each NotableEvent element gives information about a notable
		/// event that might occur during an inspection.
		/// </summary>
		[XmlArray]
		public List<NotableEventType> NotableEvents { get; set; }

		/// <remarks The required n attribute is the number of employees in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.NotableEvents.Count;
		}
    }
}
