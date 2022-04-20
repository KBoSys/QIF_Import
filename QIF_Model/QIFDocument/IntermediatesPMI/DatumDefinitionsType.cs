/*! \file DatumDefinitionsType.cs
	\brief The DatumDefinitionsType defines a list of datum definitions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumDefinitionsType
    {
        public DatumDefinitionsType() { }

		/// <remarks Each DatumDefinition element gives information about a datum./>
		[XmlElement("DatumDefinition", Type = typeof(DatumDefinitionType))]
		public List<DatumDefinitionType> DatumDefinitions { get; set; }

		/// <remarks The required n attribute is the number of datum definitions in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.DatumDefinitions.Count;
		}
	}

    /// <remarks The DatumDefinitionType defines information about a datum./>
    [XmlRoot]
    public class DatumDefinitionType : QIFIdTypeBase
    {
        public DatumDefinitionType() { }

        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).        
        /// </summary>
        [XmlElement(IsNullable = true)]
        public Primitives.AttributesType Attributes { get; set; }

        /// <remarks The DatumLabel element is the label applied to the datum feature./>
        [XmlElement(IsNullable = false)]
        public string DatumLabel { get; set; }
        
        /// <remarks The optional DatumTargetIds element is a list of the QIF ids of datum targets associated with the datum./>
        [XmlElement(IsNullable = true)]
        public Primitives.ArrayReferenceFullType DatumTargetIds { get; set; }

        /// <summary>
        /// The optional FeatureNominalIds element is a list of QIF ids of
        /// feature nominals to be used to construct the datum.
        /// </summary>
        [XmlElement(IsNullable = true)]
        public Primitives.ArrayReferenceFullType FeatureNominalIds { get; set; }
    }
}