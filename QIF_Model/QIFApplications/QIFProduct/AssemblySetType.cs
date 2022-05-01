/*! \file AssemblySetType.cs
	\brief The AssemblySetType represents a container for storing all assemblies present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
	/// <remarks The FolderAssemblyType is the assembly folder type. It contains a set of entities that define the assembly./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class FolderAssemblyType : FolderPartAssemblyBaseType
	{
		/// <remarks The ComponentIds element is an array of component identifiers present in this product definition./>
		[XmlElement()]
		public QIFLibrary.Primitives.ArrayReferenceType ComponentIds { get; set; }
	}

	/// <remarks The FoldersAssemblyType defines a folder tree of an assembly./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class FoldersAssemblyType
	{
		/// <remarks Each FolderAssembly element is a folder of an assembly./>
		[XmlElement(ElementName = "FolderAssembly", Type = typeof(FolderAssemblyType))]
		public FolderAssemblyType[] FolderAssemblies { get; set; }

		/// <remarks The required n attribute is the number of FolderAssembly elements in this set. />
		[XmlAttribute("n")]
		public int Count
		{
			get => this.FolderAssemblies.Length;
		}
	}

	/// <remarks The AssemblyType is the assembly type. It contains a set of
	/// entities, defining a feature(body and sub-components), which can be instantiated multiple times in the CAD scene.Use of assemblies
	/// simplifies maintenance of identical features and reduces the total amount of scene data./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class AssemblyType : PartAssemblyBaseType
	{
		/// <remarks The ComponentIds element is an array of component identifiers present in this product definition./>
		[XmlElement()]
		public QIFLibrary.Primitives.ArrayReferenceType ComponentIds { get; set; }

		/// <remarks The optional DefinitionExternal element is an assembly definition in non-QIF format./>
		[XmlElement(IsNullable = true)]
		public DefinitionExternalType DefinitionExternal { get; set; }

		/// <remarks FoldersAssembly is folders tree in an assembly./>
		[XmlElement()]
		public FoldersAssemblyType FoldersAssembly { get; set; }
	}

	/// <remarks The AssemblySetType represents a container for storing all assemblies present in the CAD scene./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class AssemblySetType
	{
		/// <remarks Each Assembly element is an assembly which can be used by a number of components(instances of the assembly)./>
		[XmlElement(ElementName = "Assembly", Type = typeof(AssemblyType))]
		public AssemblyType[] Assemblies { get; set; }

		/// <remarks The required n attribute is the number of assemblies in this set. />
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Assemblies.Length;
		}
	}
}
