/*! \file CompositeSegmentMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured composite segment characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The CompositeSegmentMeasurementBaseType is the abstract base type
    /// that defines the results of a measured composite segment characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSegmentSymmetryMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSegmentProfileMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSegmentPositionMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CompositeSegmentMeasurementBaseType
    {
        /// <remarks The optional Value element is the measured value./>
        public MeasuredLinearValueType Value { get; set; }

        /// <remarks The optional MaxValue element is the maximum of the measured value when reported./>
        public MeasuredLinearValueType MaxValue { get; set; }

        /// <remarks The optional MinValue element is the minimum of the measured value when reported./>
        public MeasuredLinearValueType MinValue { get; set; }

        /// <remarks The Status element is the characteristic condition: in tolerance, out of tolerance, etc./>
        public CharacteristicStatusType Status { get; set; }

        /// <remarks The optional DRFTransformActualId element is the QIF id of the
        /// actual transform associated with the mobile datum reference frame for this segment of the characteristic./>
        public Primitives.QIFReferenceType DRFTransformActualId { get; set; }

        /// <remarks The optional ZoneDataSet element gives information about the tolerance zones for the composite segment./>
        public IntermediatesPMI.ZoneDataSetType ZoneDataSet { get; set; }
    }

    /// <remarks The CompositeSegmentSymmetryMeasurementType defines the results of a measured composite segment symmetry characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentSymmetryMeasurementType : CompositeSegmentMeasurementBaseType
    {
    }

    /// <remarks The CompositeSegmentPositionMeasurementType defines the results of a measured composite segment position characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentPositionMeasurementType : CompositeSegmentMeasurementBaseType
    {
    }

    /// <remarks The CompositeSegmentProfileMeasurementType defines the results of a measured composite segment profile characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentProfileMeasurementType : CompositeSegmentMeasurementBaseType
    {
    }
}
