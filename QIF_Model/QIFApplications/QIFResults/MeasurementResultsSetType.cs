/*! \file MeasurementResultsSetType.cs
    \brief defines a set of measurement results.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFResults
{
    /// <remarks The MeasurementResultsSetType defines a set of measurement results./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasurementResultsSetType
    {
        /// <remarks Each MeasurementResults element is a measurement results in the set./>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementResults")]
        public MeasurementResultsType[] MeasurementResults { get; set; }

        /// <remarks The required n attribute is the number of measurement results in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.MeasurementResults.Length;
            set { }
        }
    }

    /// <remarks The MeasurementResultsType defines information about measurement results./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasurementResultsType
    {
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks The optional InspectionTraceability element gives traceability information that applies this set of measurement results./>
        public QIFLibrary.Traceability.InspectionTraceabilityType InspectionTraceability { get; set; }

        /// <remarks The optional ThisResultsInstanceQPId element uniquely
        /// identifies the measurement results.Different versions of the
        /// measurement results must have different ThisResultsInstanceQPId elements./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public QPIdType ThisResultsInstanceQPId { get; set; }

        /// <remarks The optional ExternalFileReferences element is a list of
        /// references to additional files created in the measurement process, e.g.photos./>
        public QIFLibrary.IntermediatesPMI.ExternalFileReferencesType ExternalFileReferences { get; set; }

        /// <remarks The optional MeasuredFeatures element gives information about
        /// the features used in the measurement results./>
        public QIFLibrary.Features.FeatureMeasurement.FeatureMeasurementsType MeasuredFeatures { get; set; }

        /// <remarks The MeasuredPointSets element is a list of measured points sets which can be referenced by feature measurements./>
        public QIFLibrary.Features.MeasuredPointSetsType MeasuredPointSets { get; set; }

        /// <remarks The optional MeasuredCharacteristics element gives information about the characteristics used in the measurement results./>
        public QIFLibrary.Characteristics.Measurement.MeasuredCharacteristicsType MeasuredCharacteristics { get; set; }

        /// <remarks The optional ActualTransforms element gives information about
        /// the actual transforms used in the measurement results.These
        /// transforms can represent actual coordinate system transforms or
        /// actual datum reference frame transforms./>
        public QIFLibrary.IntermediatesPMI.TransformListType ActualTransforms { get; set; }

        /// <remarks The optional CoordinateSystemActualTransformAssociations
        /// element gives information about the association of actual transforms with coordinate systems./>
        public QIFLibrary.IntermediatesPMI.CoordinateSystemActualTransformAssociationsType CoordinateSystemActualTransformAssociations { get; set; }

        /// <remarks The InspectionStatus element reports the status of the \\MeasurementResults./>
        public QIFLibrary.IntermediatesPMI.InspectionStatusType InspectionStatus { get; set; }

        /// <remarks The ActualComponentIds element is the list of actual component QIF ids./>
        public ArrayReferenceType ActualComponentIds { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public uint Id { get; set; }
    }
}
