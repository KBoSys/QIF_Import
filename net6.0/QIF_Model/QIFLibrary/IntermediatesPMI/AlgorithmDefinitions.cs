/*! \file AlgorithmDefinitions.cs
 	\brief The global AlgorithmDefinitions element defines algorithms.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications.QIFProduct;
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The AlgorithmType defines information about an algorithm in a software application or in a standard or specification.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AlgorithmType : QIFApplications.QIFIdTypeBase
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        [XmlElement]
        public Primitives.AttributesType? Attributes { get; set; }

        /// <remarks> This compositor provides a choice between the QIF id of a 
        /// defined software or the QIF id of a defined standard or specification. </remarks>
        #region Choice
        /// <remarks> The SoftwareId element is the id of the software application. </remarks>
        [XmlElement]
        public Primitives.QIFReferenceType? SoftwareId { get; set; }

        /// <remarks> The optional Parameters element defines software specific parameters to be used by the algorithm. </remarks>
        [XmlElement]
        public string? Parameters { get; set; }

        /// <remarks> The StandardId element is the id of the standard or specification.</remarks>
        [XmlElement]
        public Primitives.QIFReferenceType? StandardId { get; set; }

        /// <remarks> The optional Section element defines the section of the
        /// standard or specification in which the algorithm can be found. </remarks>
        [XmlElement]
        public string? Section { get; set; }
        #endregion

        /// <remarks> The Name element is the name of the algorithm. </remarks>
        [XmlElement]
        public string? Name { get; set; }

        /// <remarks> The optional Description element is a description of the algorithm. </remarks>
        [XmlElement]
        public string? Description { get; set; }
    }

    /// <remarks> The AlgorithmsType defines a list of algorithms defined in software or in a standard or specification.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AlgorithmsType : ArrayBaseType<AlgorithmType>
    {
        /// <remarks> Each Algorithm element defines information about a particular algorithm.</remarks>
        [XmlElement("Algorithm")]
        public AlgorithmType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks></remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentAlgorithmDefinitionsAlgorithm
    {
        /// <remarks></remarks>
        public QIFDocumentAlgorithmDefinitionsAlgorithmSoftwareId? SoftwareId { get; set; }

        /// <remarks></remarks>
        public string? Parameters { get; set; }

        /// <remarks></remarks>
        public string? Name { get; set; }

        /// <remarks></remarks>
        public string? Description { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id { get; set; }
    }

    /// <remarks></remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentAlgorithmDefinitionsAlgorithmSoftwareId
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value { get; set; }
    }
}
