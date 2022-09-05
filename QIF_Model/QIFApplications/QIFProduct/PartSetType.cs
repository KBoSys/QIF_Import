﻿/*! \file PartSetType.cs
    \brief The PartSetType represents a container for storing all parts present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks> The PartSetType represents a container for storing all parts present in the CAD scene.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PartSetType : ArrayBaseType<PartType>
    {
        /// <remarks> Each Part element is a part which can be used by a number of components(instances of the part).</remarks>
        [XmlElement(ElementName = "Part", Type = typeof(PartType))]
        public PartType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The PartType is the part type. It contains a set of entities,
    /// defining a feature(body), which can be instantiated multiple times
    /// in the CAD scene.Use of parts simplifies maintenance of identical
    /// features and reduces the total amount of scene data.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PartType : PartAssemblyBaseType
    {
        /// <remarks> The optional DefinitionExternal element is a part definition in non-QIF format.</remarks>
        [XmlElement()]
        public DefinitionExternalType DefinitionExternal { get; set; }

        /// <remarks> The optional PartFamily element gives information about the part that is useful for inspection planning.</remarks>
        [XmlElement()]
        public PartFamilyType PartFamily { get; set; }

        /// <remarks> FoldersPart is folders tree in the part.</remarks>
        [XmlElement()]
        public FoldersPartType FoldersPart { get; set; }
    }
}
