/*! \file MeasurandsType.cs
    \brief Defines a set of measurands.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <summary>
    /// The MeasurandsType defines a set of measurands.
    /// </summary>
    public class MeasurandsType : ArrayBaseType<MeasurandBaseType>
    {
        /// <remarks> Each Measurand element is a single measurand. </remarks>
        [XmlElement(ElementName = "EvaluateCharacteristicMeasurand", Type = typeof(EvaluateCharacteristicMeasurandType))]
        [XmlElement(ElementName = "EstablishDatumMeasurand", Type = typeof(EstablishDatumMeasurandType))]
        public MeasurandBaseType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <summary>
    /// The MeasurandBaseType is the abstract base type that defines an
    /// object, quantity, property, or condition to be measured and for a
    /// specific purpose. (Example measurands: Measure a shape feature to
    /// evaluate a specified characteristic(tolerance). Measure a shape
    /// feature to establish a datum within the context of a datum
    /// reference frame.Measure a grain feature to determine a grain
    /// size.) MeasurandTypes can be expanded in future QIF Plans versions.
    /// </summary>
    public abstract class MeasurandBaseType : QIFIdTypeBase
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.AttributesType? Attributes { get; set; }
    }

    /// <summary>
    /// The EvaluateCharacteristicMeasurandType defines a measurand to
    /// measure a feature for evaluating a specified characteristic.A
    /// characteristic item provides both the characteristic and the feature item.
    /// </summary>
    public class EvaluateCharacteristicMeasurandType : MeasurandBaseType
    {
        /// <remarks> The CharacteristicItemId element is the QIF id of the characteristic item.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.QIFReferenceType? CharacteristicItemId { get; set; }
    }

    /// <summary>
    /// The EstablishDatumMeasurandType defines a measurand to measure the
    /// features specified by a DatumDefinition in order to create a given DatumReferenceFrame.
    /// </summary>
    public class EstablishDatumMeasurandType : MeasurandBaseType
    {
        /// <remarks> The DatumDefinitionId element is the QIF id of a datum
        /// definition that participates in the DatumReferenceFrame identified by the DatumReferenceFrameId.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.QIFReferenceFullType? DatumDefinitionId { get; set; }

        /// <remarks> The DatumReferenceFrameId element is the QIF id of the
        /// datum reference frame for the specified DatumDefinitionId.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.QIFReferenceFullType? DatumReferenceFrameId { get; set; }
    }
}
