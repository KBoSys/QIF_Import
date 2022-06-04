﻿/*! \file PointDefinedCurveFeatureMeasurementType.cs
    \brief defines the point-defined curve feature measurement information for an individual point-defined curve feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The PointDefinedCurveFeatureMeasurementType defines the
    /// point-defined curve feature measurement information for an
    /// individual point-defined curve feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveFeatureMeasurementType : CurveFeatureMeasurementBaseType
    {
        /// <remarks The optional DefiningPoints element gives a list of points
        /// which defines the measured point-defined curve.The
        /// measured point-defined curve passes through these points./>
        public DefiningPointsMeasurementType DefiningPoints { get; set; }

        /// <remarks The optional Plane element is the measured plane in which
        /// the measured point-defined curve feature lies./>
        public MeasuredPlaneType Plane { get; set; }

        /// <remarks The optional Form element is the form error of the
        /// point-defined curve feature from a report or an analysis./>
        public MeasuredLinearValueType Form { get; set; }
    }

    /// <remarks The DefiningPointsMeasurementType defines a list of ordered measured feature defining points./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DefiningPointsMeasurementType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DefiningPoint")]
        public IntermediatesPMI.DefiningPointMeasurementType[] Items { get; set; }

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
        private AttrMeasuredPoint attributes = new AttrMeasuredPoint();

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
        
        /// <remarks The required n attribute is the number of measured feature
        /// defining points in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
