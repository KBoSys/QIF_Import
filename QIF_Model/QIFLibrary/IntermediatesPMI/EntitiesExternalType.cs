﻿/*! \file EntitiesExternalType.cs
    \brief The EntitiesExternalType defines a list of external model entities.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
	/// <remarks The EntityExternalType defines the association of a model entity
	/// with a QIF id.The model to which an instance of EntityExternalType
	/// belongs will be found in an instance file as the grandparent of	the instance./>
	public class EntityExternalType : QIFIdTypeBase
	{
		/// <remarks The EntityId element is the persistent model entity identifier
		/// assigned on a drawing, in a CAD model file, or on a physical model./>
		[XmlElement(IsNullable = false)]
		public string EntityId { get; set; }

		/// <remarks The optional Name element is the name of the entity./>
		[XmlElement()]
		public string Name { get; set; }

		/// <remarks The optional Description element is the description of the entity./>
		[XmlElement()]
		public string Description { get; set; }
	}

	/// <remarks The EntitiesExternalType defines a list of external model entities./>
	public class EntitiesExternalType
	{
		/// <remarks Each Entity element gives the association of a QIF id with a model entity./>
		[XmlElement(ElementName = "Entity", Type = typeof(EntityExternalType))]
		public EntityExternalType[] Entities { get; set; }

		/// <remarks The required n attribute is the number of external model entities in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Entities.Length;
			set { }
		}
	}
}