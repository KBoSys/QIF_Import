/*! \file GeometricCharacteristicStatsEvalType.cs
    \brief defines a statistical evaluation of geometric characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The GeometricCharacteristicStatsEvalType is the base type that
    /// defines a statistical evaluation of geometric characteristics.
    /// The type itself can be used to accumulate summary statistics over
    /// different types of geometric characteristics./>
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
    public partial class GeometricCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks The optional ValueStats element is the result of a statistical evaluation of measured values./>
        public StatsWithTolLinearType ValueStats { get; set; }

        /// <remarks The optional MaxValueStats element is the result of a
        /// statistical evaluation of the maxima of the measured values./>
        public StatsLinearType MaxValueStats { get; set; }

        /// <remarks The optional MinValueStats element is the result of a
        /// statistical evaluation of the minima of the measured values./>
        public StatsLinearType MinValueStats { get; set; }
    }
}
