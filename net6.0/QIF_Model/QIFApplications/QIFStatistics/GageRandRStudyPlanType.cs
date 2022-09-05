/*! \file GageRandRStudyPlanType.cs
    \brief defines information that is related to a gage repeatability

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Statistics;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks> The GageRandRStudyPlanType defines information that is related to a
    /// gage repeatability and reproducibility statistical study where a
    /// number of part samples are repeatedly measured by two or more
    /// appraisers to establish the repeatability and reproducibility of a measurement process.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GageRandRStudyPlanType : StatisticalStudyPlanBaseType
    {
        /// <remarks> The optional MeasurementDeviceIds element is a list of the
        /// ids of one or more measurement devices in the measurement system to be studied.</remarks>
        public ArrayReferenceType? MeasurementDeviceIds { get; set; }

        /// <remarks> The RandRStudyType element defines the type of the gage RandR study type.</remarks>
        public GageRandRStudyEnumType RandRStudyType { get; set; }

        /// <remarks> The NumberOfAppraisers element defines the number of appraisers taking part in the study.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfAppraisers { get; set; }

        /// <remarks> The NumberOfParts element defines the number of parts to be used in the study.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfParts { get; set; }

        /// <remarks> The NumberOfTrials element defines the number of times each part is to be measured by each appraiser.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfTrials { get; set; }

        /// <remarks> This optional compositor provides a choice between
        /// relative and absolute appraiser equipment variation criteria.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MaximumAbsoluteAppraiserVariation", typeof(CriteriaByUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("MaximumRelativeAppraiserVariation", typeof(CriterionDecimalType))]
        public object? Item1 { get; set; }

        /// <remarks> This optional compositor provides a choice between relative
        /// and absolute maximum equipment variation criteria.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MaximumAbsoluteEquipmentVariation", typeof(CriteriaByUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("MaximumRelativeEquipmentVariation", typeof(CriterionDecimalType))]
        public object? Item2 { get; set; }

        /// <remarks> This optional compositor provides a choice between relative
        /// and absolute maximum total RandR criteria.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MaximumAbsoluteTotalRandR", typeof(CriteriaByUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("MaximumRelativeTotalRandR", typeof(CriterionDecimalType))]
        public object? Item3 { get; set; }
    }

    /// <remarks> The CriteriaByUnitType defines a list of criteria for various units types.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriteriaByUnitType : ArrayBaseType<CriterionUserDefinedUnitType>
    {
        /// <remarks> The optional LinearCriterion element defines a criterion for a linear characteristic.</remarks>
        public CriterionLinearType? LinearCriterion { get; set; }

        /// <remarks> The optional AngularCriterion element defines a criterion for an angular characteristic.</remarks>
        public CriterionAngularType? AngularCriterion { get; set; }

        /// <remarks> The optional AreaCriterion element defines a criterion for an area characteristic.</remarks>
        public CriterionAreaType? AreaCriterion { get; set; }

        /// <remarks> The optional ForceCriterion element defines a criterion for a force characteristic.</remarks>
        public CriterionForceType? ForceCriterion { get; set; }

        /// <remarks> The optional MassCriterion element defines a criterion for a mass characteristic.</remarks>
        public CriterionMassType? MassCriterion { get; set; }

        /// <remarks> The optional PressureCriterion element defines a criterion for a pressure characteristic.</remarks>
        public CriterionPressureType? PressureCriterion { get; set; }

        /// <remarks> The optional SpeedCriterion element defines a criterion for a speed characteristic.</remarks>
        public CriterionSpeedType? SpeedCriterion { get; set; }

        /// <remarks> The optional TemperatureCriterion element defines a criterion for a temperature characteristic.</remarks>
        public CriterionTemperatureType? TemperatureCriterion { get; set; }

        /// <remarks> The optional TimeCriterion element defines a criterion for a time characteristic.</remarks>
        public CriterionTimeType? TimeCriterion { get; set; }

        /// <remarks> Each optional UserDefinedUnitCriterion element defines a
        /// criterion for user defined unit characteristics.This element
        /// is not to be used to define a criterion with units available in
        /// another element. In particular this element is not to be used
        /// to define a criterion with linear units, angular units, or
        /// units of temperature, area, force, mass, pressure, speed, or time.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitCriterion")]
        public CriterionUserDefinedUnitType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The GageRandRStudyEnumType enumerates the various gage RandR study types.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum GageRandRStudyEnumType
    {
        /// <remarks></remarks>
        RANGE,

        /// <remarks></remarks>
        AVGANDRANGE,

        /// <remarks></remarks>
        ANOVA,
    }
}
