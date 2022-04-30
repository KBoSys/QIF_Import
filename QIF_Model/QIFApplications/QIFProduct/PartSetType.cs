/*! \file PartSetType.cs
    \brief The PartSetType represents a container for storing all parts present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks The PartSetType represents a container for storing all parts present in the CAD scene./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PartSetType
	{
		/// <remarks Each Part element is a part which can be used by a number of components(instances of the part)./>
		[XmlElement(ElementName = "Part", Type = typeof(PartType))]
		public PartType[] Parts { get; set; }

		/// <remarks The required n attribute is the number of parts in this set./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Parts.Length;
		}
	}

	/// <remarks The PartType is the part type. It contains a set of entities,
	/// defining a feature(body), which can be instantiated multiple times
	/// in the CAD scene.Use of parts simplifies maintenance of identical
	/// features and reduces the total amount of scene data./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class PartType : PartAssemblyBaseType
	{
		/// <remarks The optional DefinitionExternal element is a part definition in non-QIF format./>
		[XmlElement(IsNullable = true)]
		public DefinitionExternalType DefinitionExternal { get; set; }

		/// <remarks The optional PartFamily element gives information about the part that is useful for inspection planning./>
		[XmlElement(IsNullable = true)]
		public PartFamilyType PartFamily { get; set; }

		/// <remarks FoldersPart is folders tree in the part./>
		[XmlElement(IsNullable = true)]
		public FoldersPartType FoldersPart { get; set; }
	}
}
