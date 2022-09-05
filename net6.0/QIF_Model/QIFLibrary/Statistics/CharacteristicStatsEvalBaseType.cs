/*! \file CharacteristicStatsEvalBaseType.cs
    \brief abstract base type that defines the results of a statistical evaluation for a set of characteristic measurements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum StatsUnitsItemsChoiceType
    {

        /// <remarks></remarks>
        DeviationStats,

        /// <remarks></remarks>
        MaxDeviationStats,

        /// <remarks></remarks>
        MaxValueStats,

        /// <remarks></remarks>
        MinDeviationStats,

        /// <remarks></remarks>
        MinValueStats,

        /// <remarks></remarks>
        ValueStats,
    }

    /// <remarks> The CharacteristicStatsEvalBaseType is the abstract base type that
    /// defines the results of a statistical evaluation for a set of characteristic measurements.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldCharacteristicStatsEvalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldCompoundCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldScarfCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareBevelCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareVCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldJCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldUCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldVCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldBevelCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSquareCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldEdgeCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSurfacingCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSeamCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldStudCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSpotCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSlotCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldPlugCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFilletCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceTextureCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedUnitCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedTimeCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedTemperatureCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedSpeedCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedPressureCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedMassCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedForceCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedAreaCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedAngularCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedLinearCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedAttributeCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleBetweenCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleFromCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularCoordinateCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatTaperCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalTaperCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChordCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalRadiusCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RadiusCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceBetweenCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceFromCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SquareCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThicknessCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DepthCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HeightCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WidthCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalDiameterCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiameterCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveLengthCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCoordinateCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometricCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProfileCharacteristicStatsEvalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileNonUniformCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointProfileCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineProfileCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RunoutCharacteristicStatsEvalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalRunoutCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularRunoutCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SymmetryCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcentricityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoaxialityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FormCharacteristicStatsEvalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherFormCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidicityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StraightnessCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatnessCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientationCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelismCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerpendicularityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularityCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CharacteristicStatsEvalBaseType
    {
        /// <remarks> The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType? Attributes { get; set; }

        /// <remarks> 
        /// This optional compositor provides a choice between a reference
        /// to the software, standard or specification, or particular algorithm used in this statistical evaluation. </remarks>
        [System.Xml.Serialization.XmlElementAttribute("AlgorithmId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("SoftwareId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("StandardId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public QIFReferenceType? ReferenceID { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsReferenceEnum ItemElementName { get; set; }

        /// <remarks> This optional compositor provides a choice between references
        /// to measured characteristics or a list of measured characteristic values.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MeasuredIds", typeof(StatsArrayIdType))]
        [System.Xml.Serialization.XmlElementAttribute("MeasuredValues", typeof(StatsValuesType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupValues", typeof(SubgroupValuesType))]
        [System.Xml.Serialization.XmlElementAttribute("Subgroups", typeof(SubgroupsType))]
        public object? MeasuredIds { get; set; }

        /// <remarks></remarks>
        public StatsEvalStatusType Status { get; set; }

        /// <remarks></remarks>
        public StudyIssuesType StudyIssues { get; set; }

        /// <remarks></remarks>
        public DistributionTransformationType DistributionTransformation { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {

        private StatsPassFailType threadStatsField;

        private StatsLinearType pitchDiameterStatsField;

        private StatsLinearType functionalSizeStatsField;

        /// <remarks></remarks>
        public StatsPassFailType ThreadStats
        {
            get
            {
                return this.threadStatsField;
            }
            set
            {
                this.threadStatsField = value;
            }
        }

        /// <remarks></remarks>
        public StatsLinearType PitchDiameterStats
        {
            get
            {
                return this.pitchDiameterStatsField;
            }
            set
            {
                this.pitchDiameterStatsField = value;
            }
        }

        /// <remarks></remarks>
        public StatsLinearType FunctionalSizeStats
        {
            get
            {
                return this.functionalSizeStatsField;
            }
            set
            {
                this.functionalSizeStatsField = value;
            }
        }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceTextureCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {

        private StatsWithTolLinearType roughnessAverageValueStatsField;

        /// <remarks></remarks>
        public StatsWithTolLinearType RoughnessAverageValueStats
        {
            get
            {
                return this.roughnessAverageValueStatsField;
            }
            set
            {
                this.roughnessAverageValueStatsField = value;
            }
        }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedUnitCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolUserDefinedUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsUserDefinedUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsUserDefinedUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsUserDefinedUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsUserDefinedUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolUserDefinedUnitType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedTimeCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolTimeType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsTimeType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsTimeType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsTimeType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsTimeType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolTimeType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedTemperatureCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolTemperatureType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsTemperatureType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsTemperatureType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsTemperatureType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsTemperatureType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolTemperatureType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedSpeedCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolSpeedType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsSpeedType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsSpeedType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsSpeedType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsSpeedType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolSpeedType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedPressureCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolPressureType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsPressureType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsPressureType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsPressureType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsPressureType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolPressureType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedMassCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolMassType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsMassType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsMassType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsMassType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsMassType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolMassType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedForceCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolForceType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsForceType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsForceType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsForceType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsForceType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolForceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedAreaCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolAreaType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsAreaType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsAreaType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsAreaType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsAreaType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolAreaType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedAngularCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolAngularType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedLinearCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolLinearType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedAttributeCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        public StatsPassFailType AttributeStats { get; set; }
    }
}
