/*! \file NodeBaseType.cs
	\brief The NodeBaseType is the abstract base type for model elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.PrimitivesPD
{
	/// <remarks The NodeBaseType is the abstract base type for model elements./>
	public abstract class NodeBaseType
	{
		/// <remarks The optional label attribute is the model entity "nameplate".
		/// Normally it can be seen at the entity item in the project tree./>
		[XmlElement(IsNullable = true)]
		public string Label { get; set; }
	}

	/// <remarks The NodeWithIdBaseType is the abstract base type for model elements with id./>
	public abstract class NodeWithIdBaseType : NodeBaseType
	{
		/// <remarks The optional Attributes element contains user defined
		/// attributes(typified, binary array, or XML structured)./>
		[XmlElement(IsNullable = true)]
		public Primitives.AttributesType Attributes { get; set; }

		[XmlIgnore]
		public QIFIdType QIFID { get; set; }

		/// <remarks The required id attribute is the unique model entity identifier./>
		[XmlAttribute]
		public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
	}
}
