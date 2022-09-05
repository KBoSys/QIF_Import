/*! \file ProductDataQualityType.cs
    \brief The ProductDataQualityType collects required product data quality verification and validation checks (PDQ).

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Traceability
{
    /// <remarks> The ProductDataQualityType collects required product
    /// data quality verification and validation checks(PDQ).
    /// </remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ProductDataQualityType
    {
        public ProductDataQualityType() { }

        /// <remarks> The ChecksPerformed element indicates whether required product data quality checks gave been performed.</remarks>
        [XmlElement]
        public bool ChecksPerformed { get; set; }

        /// <remarks> The ChecksApproved element indicates whether required product data quality checks have been approved.</remarks>
        [XmlElement]
        public bool ChecksApproved { get; set; }

        /// <remarks> The Declaration element is a declaration of the product data quality.</remarks>
        [XmlElement]
        public string? Declaration { get; set; }

        /// <remarks> The optional ProductDataQualityChecks element describes one or more product data quality checks.</remarks>
        [XmlElement]
        public ProductDataQualityChecksType ProductDataQualityChecks { get; set; }
    }

    /// <remarks> The ProductDataQualityType defines a list of product data quality verification and validation checks.</remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ProductDataQualityChecksType
    {
        public ProductDataQualityChecksType() { }

        /// <remarks> Each ProductDataQualityCheckType element describes a single product data quality check..</remarks>
        [XmlElement("ProductDataQualityCheck", Type = typeof(ProductDataQualityCheckType))]
        public ProductDataQualityCheckType[] ProductDataQualityChecks { get; set; }

        /// <remarks> The required n attribute is the number of employees in the list.</remarks>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.ProductDataQualityChecks.Length;
            set { }
        }
    }

    /// <remarks> The ProductDataQualityCheckType contains information about a product data quality verification and validation check and its result.</remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ProductDataQualityCheckType
    {
        public ProductDataQualityCheckType() { }

        /// <remarks> The Type element defines the area to which this product data quality verification and validation check applies.</remarks>
        [XmlElement]
        public ProductDataQualityAreaType Type { get; set; }

        /// <remarks> The Description element describes this particular product data quality verification and validation check.</remarks>
        [XmlElement]
        public string? Description { get; set; }

        /// <remarks> The Requirements element defines the requirements of this product data quality check in natural language.</remarks>
        [XmlElement]
        public string? Requirements { get; set; }

        /// <remarks>
        /// The optional SourceOfRequiredness element defines why this
        /// product data quality check is requires, i.e., by citing an
        /// external customer requirement such as MilStd.
        /// </remarks>
        [XmlElement]
        public string? SourceOfRequiredness { get; set; }

        /// <remarks>
        /// The optional ApplicationTool element gives information about
        /// the software application used to perform this product data
        /// quality check. </remarks>
        [XmlElement]
        public IntermediatesPMI.SoftwareType ApplicationTool { get; set; }

        /// <remarks> 
        /// The optional XsltFile element is the URI for an XSLT file used
        /// or to be used in a QIF document XSLT check.</remarks>
        [XmlElement]
        public Primitives.UriType XsltFile { get; set; }

        /// <remarks> 
        /// The ResultStatement element makes a statement about the result
        /// of this product data quality check in natural language.</remarks>
        [XmlElement]
        public string? ResultStatement { get; set; }

        /// <remarks> 
        /// The ResultStatus element is the status of this product data
        /// quality check.</remarks>
        [XmlElement]
        public CheckStatusEnumType ResultStatus { get; set; }
    }

    /// <summary>
    /// The CheckStatusEnumType enumerates values that describe the
    /// status of a product data quality check.
    /// </summary>
    public enum CheckStatusEnumType
    {
        PASS,
        FAIL,
        PENDING,
    }

    /// <remarks> 
    /// The ProductDataQualityAreaType defines the area to which a product
    /// data quality verification and validation check applies.</remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ProductDataQualityAreaType
    {
        public ProductDataQualityAreaType() { }

        /// <remarks> The AreaEnum element describes an often-used product data quality area.</remarks>
        [XmlElement]
        public ProductDataQualityAreaEnumType AreaEnum { get; set; }

        /// <remarks> The OtherArea element describes the product data quality area in natural language.</remarks>
        [XmlElement]
        public string? OtherArea { get; set; }
    }

    /// <summary>
    /// The ProductDataQualityAreaEnumType enumerates values that describe
    /// product data quality areas.
    /// </summary>
    public enum ProductDataQualityAreaEnumType
    {
        OVERALL,
        PRODUCT_GEOMETRIC_DATA,
        PRODUCT_MANUFACTURING_INFORMATION,
        BUSINESS_PRACTICE,
        DESIGN_PRACTICE,
        DERIVATIVE_COMPARE,
        UNDEFINED,
    }
}
