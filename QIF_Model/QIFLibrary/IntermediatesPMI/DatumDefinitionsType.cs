/*! \file DatumDefinitionsType.cs
	\brief The DatumDefinitionsType defines a list of datum definitions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumDefinitionsType : ArrayBaseType<DatumDefinitionType>
    {
        /// <remarks> Each DatumDefinition element gives information about a datum.</remarks>
        [XmlElement("DatumDefinition")]
        public DatumDefinitionType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The DatumDefinitionType defines information about a datum.</remarks>
    [XmlRoot]
    public class DatumDefinitionType : QIFIdTypeBase
    {
        public DatumDefinitionType() { }

        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).        
        /// </summary>
        [XmlElement()]
        public Primitives.AttributesType Attributes { get; set; }

        /// <remarks> The DatumLabel element is the label applied to the datum feature.</remarks>
        [XmlElement(IsNullable = false)]
        public string DatumLabel { get; set; }

        /// <remarks> The optional DatumTargetIds element is a list of the QIF ids of datum targets associated with the datum.</remarks>
        [XmlElement()]
        public Primitives.ArrayReferenceFullType DatumTargetIds { get; set; }

        /// <summary>
        /// The optional FeatureNominalIds element is a list of QIF ids of
        /// feature nominals to be used to construct the datum.
        /// </summary>
        [XmlElement()]
        public Primitives.ArrayReferenceFullType FeatureNominalIds { get; set; }
    }
}