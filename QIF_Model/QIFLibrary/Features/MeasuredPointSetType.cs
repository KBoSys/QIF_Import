/*! \file MeasuredPointSetType.cs
    \brief defines a list of ordered measurement points for a feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
    /// <remarks The MeasuredPointSetType defines a list of ordered measurement
    /// points for a feature. The number of points in the set is defined by
    /// the count attribute. The point set may be optionally ordered into a mesh./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredPointSetType
    {
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks The optional Units element specifies the units used in the point set./>
        public OtherUnitsType Units { get; set; }

        /// <remarks This optional compositor provides a choice between a coordinate
        /// system or a transform. If this choice is not present then the
        /// measured point set is defined in the common coordinate system./>
        [System.Xml.Serialization.XmlElementAttribute("CoordinateSystemId", typeof(QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("TranformId", typeof(QIFReferenceType))]
        public QIFReferenceType CoordinateSystemOrTransform { get; set; }

        /// <remarks This compositor provides a choice between decimal or binary XYZ measured point values./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryPoints", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("Points", typeof(double))]
        public object BinaryOrDecimalXYZ { get; set; }

        /// <remarks This optional compositor provides a choice between decimal or
        /// binary IJK normal vector values.The normal vectors can be used
        /// for probe compensation or for designating material side for scan data./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryNormals", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("Normals", typeof(double))]
        public object BinaryOrDecimalIJK { get; set; }

        /// <remarks This compositor provides a choice between shared or individual flags for probe compensation./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryCompensated", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("Compensated", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("Compensations", typeof(bool))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("CompensationElementName")]
        public object ProbeCompensation { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CompensationChoiceType CompensationElementName { get; set; }

        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
        public enum CompensationChoiceType
        {
            BinaryCompensated,
            Compensated,
            Compensations,
        }

        /// <remarks This optional compositor provides a choice between shared or individual probe radii for probe compensation./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryProbeRadii", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("ProbeRadii", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("ProbeRadius", typeof(decimal))]
        public object ProbeRadii { get; set; }

        /// <remarks The MeasurementDeviceId element is the QIF id of the measurement device used to measure all points./>
        public QIFReferenceType MeasurementDeviceId { get; set; }

        /// <remarks This optional compositor provides a choice between shared or individual sensor ids./>
        [System.Xml.Serialization.XmlElementAttribute("BinarySensorIds", typeof(ArrayBinaryQIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("SensorId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("SensorIds", typeof(ListQIFReferenceType))]
        public object SensorIds { get; set; }

        /// <remarks This optional compositor provides a choice between shared or individual tip ids./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryTipIds", typeof(ArrayBinaryQIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("TipId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("TipIds", typeof(ListQIFReferenceType))]
        public object TipIds { get; set; }

        /// <remarks This optional compositor provides a choice between text or binary nominal point ids./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryMeasurePointNominalIds", typeof(ArrayBinaryQIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("MeasurePointNominalIds", typeof(ListQIFReferenceFullType))]
        public object NominalPointIds { get; set; }

        /// <remarks This optional compositor provides a choice between a single
        /// time stamp for the whole point set, or a list of time stamps for each point./>
        [System.Xml.Serialization.XmlElementAttribute("TimeStamp", typeof(System.DateTime))]
        [System.Xml.Serialization.XmlElementAttribute("TimeStamps", typeof(System.DateTime))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("TimeStampElementName")]
        public System.DateTime TimeStamp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TimeStampChoiceType TimeStampElementName { get; set; }

        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
        public enum TimeStampChoiceType
        {
            TimeStamp,
            TimeStamps,
        }

        /// <remarks This optional compositor provides a choice between text or binary quality factors./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryQuality", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("Quality", typeof(double))]
        public object QualityFactors { get; set; }

        /// <remarks This optional compositor provides a choice between text or binary deviations./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryDeviations", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("Deviations", typeof(double))]
        public object Deviations { get; set; }

        /// <remarks This optional compositor provides a choice between text or binary representations of colors representing deviations./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryColors", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("Colors", typeof(string), DataType = "integer")]
        public object Colors { get; set; }

        /// <remarks The number of triangularfacets in the mesh defined by three point indices./>
        public uint NumberOfFacets { get; set; }

        /// <remarks This compositor provides a choice between text or binary facet indexes./>
        [System.Xml.Serialization.XmlElementAttribute("BinaryPointIndices", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("PointIndices", typeof(ArrayI3Type))]
        public object FacetIndexes { get; set; }

        /// <remarks The required count attribute gives the number of measured points in the measured point set./>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public uint Count { get; set; }

        /// <remarks The AttrPoint attribute group defines accuracies common to all measurement points for a feature./>
        #region ref="AttrPoint"
        private AttrPoint attr = new AttrPoint();

        [XmlAttribute("linearUnit", DataType = "token")]
        public string LinearUnit { get => attr.LinearUnit; set => attr.LinearUnit = value; }

        [XmlAttribute("decimalPlaces")]
        public uint DecimalPlaces { get => attr.DecimalPlaces; set => attr.DecimalPlaces = value; }

        [XmlAttribute("significantFigures")]
        public uint SignificantFigures { get => attr.SignificantFigures; set => attr.SignificantFigures = value; }

        [XmlAttribute("validity")]
        public ValidityEnumType Validity { get => attr.Validity; set => attr.Validity = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValiditySpecified { get; set; }

        [XmlAttribute("xDecimalPlaces")]
        public uint XDecimalPlaces { get => attr.XDecimalPlaces; set => attr.XDecimalPlaces = value; }

        [XmlAttribute("xSignificantFigures")]
        public uint XSignificantFigures { get => attr.XSignificantFigures; set => attr.XSignificantFigures = value; }

        [System.Xml.Serialization.XmlAttributeAttribute("xValidity")]
        public ValidityEnumType XValidity { get => attr.XValidity; set => attr.XValidity = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XValiditySpecified { get; set; }

        [XmlAttribute("yDecimalPlaces")]
        public uint YDecimalPlaces { get => attr.YDecimalPlaces; set => attr.YDecimalPlaces = value; }

        [XmlElement("ySignificantFigures")]
        public uint YSignificantFigures { get => attr.YSignificantFigures; set => attr.YSignificantFigures = value; }

        [XmlAttribute("yValidity")]
        public ValidityEnumType YValidity { get => attr.YValidity; set => attr.YValidity = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YValiditySpecified { get; set; }

        [XmlAttribute("zDecimalPlaces")]
        public uint ZDecimalPlaces { get => attr.ZDecimalPlaces; set => attr.ZDecimalPlaces = value; }

        [XmlAttribute("zSignificantFigures")]
        public uint ZSignificantFigures { get => attr.ZSignificantFigures; set => attr.ZSignificantFigures = value; }

        [XmlAttribute("zValidity")]
        public ValidityEnumType ZValidity { get => attr.ZValidity; set => attr.ZValidity = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZValiditySpecified { get; set; }
        #endregion

        /// <remarks The AttrMeasurementPoint attribute group defines uncertainties and errors common to all measurement points for a feature./>
        #region ref="AttrMeasuredPoint"
        private AttrMeasuredPoint attributes;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("combinedUncertainty")]
        public decimal CombinedUncertainty
        {
            get => this.attributes.CombinedUncertainty;
            set => this.attributes.CombinedUncertainty = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CombinedUncertaintySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("meanError")]
        public decimal MeanError
        {
            get => this.attributes.MeanError;
            set => this.attributes.MeanError = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeanErrorSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("xCombinedUncertainty")]
        public decimal XCombinedUncertainty
        {
            get => this.attributes.XCombinedUncertainty;
            set => this.attributes.XCombinedUncertainty = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XCombinedUncertaintySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("xMeanError")]
        public decimal XMeanError
        {
            get => this.attributes.XMeanError;
            set => this.attributes.XMeanError = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XMeanErrorSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("yCombinedUncertainty")]
        public decimal YCombinedUncertainty
        {
            get => this.attributes.YCombinedUncertainty;
            set => this.attributes.YCombinedUncertainty = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YCombinedUncertaintySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("yMeanError")]
        public decimal YMeanError
        {
            get => this.attributes.YMeanError;
            set => this.attributes.YMeanError = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YMeanErrorSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("zCombinedUncertainty")]
        public decimal ZCombinedUncertainty
        {
            get => this.attributes.ZCombinedUncertainty;
            set => this.attributes.ZCombinedUncertainty = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZCombinedUncertaintySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("zMeanError")]
        public decimal ZMeanError
        {
            get => this.attributes.ZMeanError;
            set => this.attributes.ZMeanError = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZMeanErrorSpecified { get; set; }
        #endregion

        /// <remarks The required id attribute is the QIF id of the measured point set, used for referencing./>
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public QIFIdType Id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredPointSetsType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasuredPointSet")]
        public MeasuredPointSetType[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
