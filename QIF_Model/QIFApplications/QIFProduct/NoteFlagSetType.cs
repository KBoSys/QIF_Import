﻿/*! \file NoteFlagSetType.cs
	\brief defines an array of flag notes.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
	/// <remarks defines an array of flag notes./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class NoteFlagSetType : ArrayBaseType<NoteFlagType>
	{
		/// <remarks Each NoteFlag element is a flag note./>
		[System.Xml.Serialization.XmlElementAttribute("NoteFlag")]
		public override NoteFlagType[] Items => base.Items;
	}
}
