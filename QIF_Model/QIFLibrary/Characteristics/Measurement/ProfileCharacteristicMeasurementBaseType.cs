/*! \file ProfileCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured profile characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The ProfileCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured profile characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileNonUniformCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointProfileCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineProfileCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ProfileCharacteristicMeasurementBaseType : GeometricCharacteristicMeasurementBaseType
    {
        /// <remarks The optional WorstPositiveDeviation element is the most
        /// positive deviation in the direction of the surface or curve
        /// normal. This deviation can be a negative number./>
        public LinearValueType WorstPositiveDeviation { get; set; }

        /// <remarks The optional WorstNegativeDeviation element is the most
        /// negative deviation in the direction of the surface or curve
        /// normal.This deviation can be a positive number./>
        public LinearValueType WorstNegativeDeviation { get; set; }

        /// <remarks The optional PointDeviations element is a list of the
        /// vector deviations of measurement points from nominal./>
        public PointDeviationsType PointDeviations { get; set; }

        /// <remarks The optional DatumsOk element specifies whether the datum
        /// features passed all their associated characteristic
        /// evaluations.The element is set to "true" for passed all,
        /// is set to "false" for did not pass all, and is not present
        /// if the status of the datum features is unknown./>
        public bool DatumsOk { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumsOkSpecified { get; set; }

        /// <remarks The optional DRFTransformActualId element is the QIF id of
        /// the actual transform associated with the mobile DRF of this characteristic./>
        public QIFReferenceType DRFTransformActualId { get; set; }

        /// <remarks The optional SecondCompositeSegmentProfileMeasurement
        /// gives information about the second segment of a measured composite frame profile characteristic./>
        public CompositeSegmentProfileMeasurementType SecondCompositeSegmentProfileMeasurement { get; set; }

        /// <remarks The optional ThirdCompositeSegmentProfileMeasurement gives
        /// information about the third segment of a measured
        /// composite frame profile characteristic. This element may be used only if the
        /// SecondCompositeSegmentProfileMeasurement element is used./>
        public CompositeSegmentProfileMeasurementType ThirdCompositeSegmentProfileMeasurement { get; set; }

        /// <remarks The optional FourthCompositeSegmentProfileMeasurement gives
        /// information about the fourth segment of a measured
        /// composite frame profile characteristic. This element may be used only if the
        /// ThirdCompositeSegmentProfileMeasurement element is used./>
        public CompositeSegmentProfileMeasurementType FourthCompositeSegmentProfileMeasurement { get; set; }
    }

    /// <remarks The SurfaceProfileNonUniformCharacteristicMeasurementType defines
    /// the results of a measured non-uniform surface profile characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceProfileNonUniformCharacteristicMeasurementType : ProfileCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The SurfaceProfileCharacteristicMeasurementType defines the results
    /// of a measured profile of a surface characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceProfileCharacteristicMeasurementType : ProfileCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The PointProfileCharacteristicMeasurementType defines the results
    /// of a measured point profile characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointProfileCharacteristicMeasurementType : ProfileCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The LineProfileCharacteristicMeasurementType defines the results of
    /// a measured profile of a line characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineProfileCharacteristicMeasurementType : ProfileCharacteristicMeasurementBaseType
    {
    }

}
