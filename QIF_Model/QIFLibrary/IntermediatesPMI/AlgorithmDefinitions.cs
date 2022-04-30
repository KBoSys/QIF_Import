/*! \file AlgorithmDefinitions.cs
 	\brief The global AlgorithmDefinitions element defines algorithms.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The AlgorithmType defines information about an algorithm in a software application or in a standard or specification./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AlgorithmType : QIFApplications.QIFIdTypeBase
	{
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        [XmlElement(IsNullable = true)]
        public Primitives.AttributesType Attributes {get; set;}

		/// <remarks This compositor provides a choice between the QIF id of a 
		/// defined software or the QIF id of a defined standard or specification. />
		#region Choice
		/// <remarks The SoftwareId element is the id of the software application. />
		[XmlElement(IsNullable = true)]
        public Primitives.QIFReferenceType SoftwareId { get; set; }

        /// <remarks The optional Parameters element defines software specific parameters to be used by the algorithm. />
        [XmlElement(IsNullable = true)]
        public string Parameters { get; set; }

        /// <remarks The StandardId element is the id of the standard or specification./>
        [XmlElement(IsNullable = true)]
        public Primitives.QIFReferenceType StandardId { get; set; }

        /// <remarks The optional Section element defines the section of the
        /// standard or specification in which the algorithm can be found. />
        [XmlElement(IsNullable = true)]
        public string Section { get; set; }
        #endregion

        /// <remarks The Name element is the name of the algorithm. />
        [XmlElement(IsNullable = false)]
        public string Name { get; set; }

        /// <remarks The optional Description element is a description of the algorithm. />
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
    }

    /// <remarks The AlgorithmsType defines a list of algorithms defined in software or in a standard or specification./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AlgorithmsType
    {
        /// <remarks Each Algorithm element defines information about a particular algorithm./>
        [XmlElement("Algorithm")]
        public AlgorithmType[] Algorithms { get; set; }

        /// <remarks The required n attribute is the number of algorithm definitions in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.Algorithms.Length;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentAlgorithmDefinitionsAlgorithm
    {

        private QIFDocumentAlgorithmDefinitionsAlgorithmSoftwareId softwareIdField;

        private string parametersField;

        private string nameField;

        private string descriptionField;

        private uint idField;

        /// <remarks/>
        public QIFDocumentAlgorithmDefinitionsAlgorithmSoftwareId SoftwareId
        {
            get
            {
                return this.softwareIdField;
            }
            set
            {
                this.softwareIdField = value;
            }
        }

        /// <remarks/>
        public string Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentAlgorithmDefinitionsAlgorithmSoftwareId
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

}
