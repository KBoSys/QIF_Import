/*! \file OrientationCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured orientation characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The OrientationCharacteristicMeasurementBaseType is the abstract
    /// base type that defines the results of a measured orientation characteristic evaluation.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelismCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerpendicularityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularityCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class OrientationCharacteristicMeasurementBaseType : GeometricCharacteristicMeasurementBaseType
    {
        /// <remarks> The optional DatumsOk element specifies whether the datum
        /// features passed all their associated characteristic
        /// evaluations.The element is set to "true" for passed all,
        /// is set to "false" for did not pass all, and is not present
        /// if the status of the datum features is unknown.</remarks>
        public bool DatumsOk { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumsOkSpecified { get; set; }

        /// <remarks> The optional Bonus element is the size of the applied bonus.</remarks>
        public MeasuredLinearValueType Bonus { get; set; }

        /// <remarks> The optional ReferenceLength element is the length of the applied tolerance zone.</remarks>
        public LinearValueType ReferenceLength { get; set; }

        /// <remarks> The optional DRFTransformActualId element is the QIF id of
        /// the measured transform associated with the mobile datum reference frame for this characteristic.</remarks>
        public QIFReferenceType DRFTransformActualId { get; set; }
    }

    /// <remarks> The ParallelismCharacteristicMeasurementType defines the results of a measured parallelism characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ParallelismCharacteristicMeasurementType : OrientationCharacteristicMeasurementBaseType
    {
    }

    /// <remarks> The PerpendicularityCharacteristicMeasurementType defines the results of a measured perpendicularity characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PerpendicularityCharacteristicMeasurementType : OrientationCharacteristicMeasurementBaseType
    {
    }

    /// <remarks> The AngularityCharacteristicMeasurementType defines the results of a measured angularity characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularityCharacteristicMeasurementType : OrientationCharacteristicMeasurementBaseType
    {
    }
}
