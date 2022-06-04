/*! \file PointSetNominalType.cs
    \brief defines a set of ordered nominal target measurement points

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The PointSetNominalType defines a set of ordered nominal
    /// target measurement points for a feature with a QIF id for referencing./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointSetNominalType
    {
        /// <remarks Each MeasurePoint element is an individual nominal measurement point for a feature./>
        [System.Xml.Serialization.XmlElementAttribute("MeasurePoint")]
        public IntermediatesPMI.MeasurePointNominalType[] MeasurePoints { get; set; }

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.MeasurePoints.Length;
            set { }
        }

        /// <remarks The QIF id of the measured point set, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The required id attribute is the QIF id of the measured point set, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public UInt32 Id { get => this.QIFID; set => this.QIFID = value; }
    }
}
