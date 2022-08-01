/*! \file LocationCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured location characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The LocationCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured location characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SymmetryCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcentricityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoaxialityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class LocationCharacteristicMeasurementBaseType : GeometricCharacteristicMeasurementBaseType
    {
        /// <remarks The optional ZoneDataSet element gives information about the
        /// tolerance zones for the characteristic./>
        public IntermediatesPMI.ZoneDataSetType ZoneDataSet { get; set; }

        /// <remarks The optional DatumsOk element specifies whether the datum
        /// features passed all their associated characteristic
        /// evaluations.The element is set to "true" for passed all,
        /// is set to "false" for did not pass all, and is not present
        /// if the status of the datum features is unknown./>
        public bool DatumsOk { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumsOkSpecified { get; set; }
    }

    /// <remarks The SymmetryCharacteristicMeasurementType defines the results of a measured symmetry characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SymmetryCharacteristicMeasurementType : LocationCharacteristicMeasurementBaseType
    {
        /// <remarks The optional SecondCompositeSegmentSymmetryMeasurement
        /// gives information about the second segment of a measured composite frame symmetry characteristic./>
        public CompositeSegmentSymmetryMeasurementType SecondCompositeSegmentSymmetryMeasurement { get; set; }

        /// <remarks The optional ThirdCompositeSegmentSymmetryMeasurement gives
        /// information about the third segment of a measured
        /// composite frame symmetry characteristic.This element may be used only if the
        /// SecondCompositeSegmentSymmetryMeasurement element is used./>
        public CompositeSegmentSymmetryMeasurementType ThirdCompositeSegmentSymmetryMeasurement { get; set; }
    }

    /// <remarks The ConcentricityCharacteristicMeasurementType defines the results of a measured concentricity characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConcentricityCharacteristicMeasurementType : LocationCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The CoaxialityCharacteristicMeasurementType defines the results of
    /// a measured coaxiality characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoaxialityCharacteristicMeasurementType : LocationCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The PositionCharacteristicMeasurementType defines the results of a measured position characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PositionCharacteristicMeasurementType : LocationCharacteristicMeasurementBaseType
    {
        /// <remarks The optional Bonus element is the size of the applied bonus./>
        public MeasuredLinearValueType Bonus { get; set; }

        /// <remarks The optional DRFTransformActualId element is the QIF id of
        /// the actual transform associated with the mobile DRF of this characteristic./>
        public Primitives.QIFReferenceType DRFTransformActualId { get; set; }

        /// <remarks The optional SecondCompositeSegmentPositionMeasurement gives
        /// information about the second measured composite segment characteristic evaluation./>
        public CompositeSegmentPositionMeasurementType SecondCompositeSegmentPositionMeasurement { get; set; }

        /// <remarks The optional ThirdCompositeSegmentPositionMeasurement gives
        /// information about the third measured composite segment characteristic evaluation.This element may be used
        /// only if the SecondCompositeSegmentPositionMeasurement element is used./>
        public CompositeSegmentPositionMeasurementType ThirdCompositeSegmentPositionMeasurement { get; set; }

        /// <remarks The optional FourthCompositeSegmentPositionMeasurement
        /// gives information about the fourth measured composite segment characteristic evaluation.This element may be
        /// used only if the ThirdCompositeSegmentPositionMeasurement element is used./>
        public CompositeSegmentPositionMeasurementType FourthCompositeSegmentPositionMeasurement { get; set; }
    }
}
