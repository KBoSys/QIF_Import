/*! \file ComponentSetType.cs
    \brief The ComponentSetType represents a container for storing all components present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
	/// <remarks The ComponentType defines a single instance of a part or an assembly./>
	public class ComponentType : DrawableBaseType
	{
		/// <remarks The optional Transform element is an identifier of the
		/// transformation matrix that maps the component into the product./>
		[XmlElement()]
		public QIFLibrary.Primitives.ElementReferenceType Transform { get; set; }

		/// <remarks The optional UUID element is a persistent identifier for
		/// the component.If used, it should be generated using a widely accepted UUID generator./>
		[XmlElement()]
		public QIFLibrary.Primitives.QPIdType UUID { get; set; }

		/// <remarks The optional Traceability element gives traceability information for a component./>
		[XmlElement()]
		public QIFLibrary.Traceability.ProductTraceabilityType Traceability { get; set; }

		/// <remarks The Part element is an identifier of a part to be instantiated./>
		[XmlElement()]
		public QIFLibrary.Primitives.ElementReferenceType Part { get; set; }

		/// <remarks The Assembly element is an identifier of an assembly to be instantiated./>
		[XmlElement()]
		public QIFLibrary.Primitives.ElementReferenceType Assembly { get; set; }
	}

	/// <remarks The ComponentSetType represents a container for storing all components present in the CAD scene./>
	[System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ComponentSetType
	{
		/// <remarks Each Component element is an instance of a part template./>
		[XmlElement(ElementName = "Component", Type = typeof(ComponentType))]
		public ComponentType[] Components { get; set; }

		/// <remarks The required n attribute is the number of components in this set./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Components.Length;
			set { }
		}
	}
}
