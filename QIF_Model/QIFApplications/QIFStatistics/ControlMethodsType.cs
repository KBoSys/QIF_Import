/*! \file ControlMethodsType.cs
    \brief defines a list of control methods.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Statistics;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks The ControlMethodsType defines a list of control methods./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ControlMethodsType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ControlMethod")]
        public ControlMethodType[] ControlMethods { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)ControlMethods.Length;
            set { }
        }
    }

    /// <remarks The ControlMethodType defines the control method for detecting statistical process control issues./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ControlMethodType
    {
        /// <remarks The optional AssignableCauseIds element is a list of the QIF
        /// ids of possible assignable causes for this control issue./>
        public ArrayReferenceType AssignableCauseIds { get; set; }

        /// <remarks The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks 
        /// The NumOutOfTolerance element defines the number of characteristic values that must exceed upper or lower specification limit for a control issue to exist.
        /// The CpThreshold element defines the Cp threshold below which a control issue might exist.
        /// The CpkThreshold element defines the Cpk threshold below which a control issue might exist.
        /// The PpThreshold element defines the Pp threshold below which a control issue might exist.
        /// The PpkThreshold element defines the Ppk threshold below which a control issue might exist.
        /// The NumOutOfControl element defines the number of characteristic values that must exceed upper or lower control limits for a control issue to exist.
        /// The TrendGrouping element defines the number of adjacent characteristic measurements that must be trending either up or down as a group for a control issue to exist.
        ///     Commonpractice is to flag a control issue when 6 or more measurements are trending.
        /// The SkewGrouping element defines the number of adjacent characteristic measurements that must be grouped on one side
        ///     of the mean for a control issue to exist.Common practice is to flag a control issue when 8 or more measurements are skewed to one side of the mean.
        /// The OneThirdGrouping element defines the fraction of adjacent characteristic measurements that must deviate from the mean by one third or more of the difference between a control
        ///     limit and the mean and all on the same side of the mean for acontrol issue to exist.Common practice is to flag a control
        ///     issue when 4 or more out of 5 measurements are one third or
        ///     more of the way from the mean to the control limit and on one side of the mean.
        /// The TwoThirdsGrouping element defines the fraction of adjacent characteristic measurements that must deviate from
        ///     the mean by two thirds or more of the difference between a control limit and the mean and all on the same side of the
        ///     mean for a control issue to exist.Common practice is to flag a control issue when 2 or more out of 3 measurements are two
        ///     thirds or more of the way from the mean to the control limit and on one side of the mean.
        /// The Stratification element defines the fraction of adjacent characteristic measurements that must deviate from the mean
        ///     by one third or more of the difference between a control limit and the mean and on either side of the mean for a
        ///     control issue to exist.
        /// The NumOutOfControlRng element defines the number of characteristic subgroup ranges that must exceed upper or lower control range limits for a control issue to exist./>
        [System.Xml.Serialization.XmlElementAttribute("CpThreshold", typeof(CriterionDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("CpkThreshold", typeof(CriterionDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("NumOutOfControl", typeof(CriterionIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("NumOutOfControlRng", typeof(CriterionIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("NumOutOfTolerance", typeof(CriterionIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("OneThirdGrouping", typeof(CriterionOutOfType))]
        [System.Xml.Serialization.XmlElementAttribute("Oscillation", typeof(CriterionOutOfType))]
        [System.Xml.Serialization.XmlElementAttribute("PpThreshold", typeof(CriterionDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("PpkThreshold", typeof(CriterionDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SkewGrouping", typeof(CriterionIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("Stratification", typeof(CriterionOutOfType))]
        [System.Xml.Serialization.XmlElementAttribute("TrendGrouping", typeof(CriterionIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("TwoThirdsGrouping", typeof(CriterionOutOfType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ControlMethodElementName")]
        public object Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ControlMethodChoiceType ControlMethodElementName { get; set; }

        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The required id attribute is the QIF id of the control method, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ControlMethodChoiceType
    {
        /// <remarks/>
        CpThreshold,

        /// <remarks/>
        CpkThreshold,

        /// <remarks/>
        NumOutOfControl,

        /// <remarks/>
        NumOutOfControlRng,

        /// <remarks/>
        NumOutOfTolerance,

        /// <remarks/>
        OneThirdGrouping,

        /// <remarks/>
        Oscillation,

        /// <remarks/>
        PpThreshold,

        /// <remarks/>
        PpkThreshold,

        /// <remarks/>
        SkewGrouping,

        /// <remarks/>
        Stratification,

        /// <remarks/>
        TrendGrouping,

        /// <remarks/>
        TwoThirdsGrouping,
    }
}
